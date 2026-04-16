using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using convenience_store_management_system.Models;
using CSMS.Database;
using CSMS.Repositories;
using CSMS.Services;


public class InvoiceService
{
    private ProductRepository productRepository = new ProductRepository();

    DbConnectionHelper db = new DbConnectionHelper();

    public void UpdateStockAfterInvoice(List<CartItem> cartItems)
    {
        foreach (var item in cartItems)
        {
            productRepository.UpdateStock(item.ProductId.ToString(), item.Quantity);
        }
    }

    public void CreateInvoice(List<CartItem> items, string paymentMethod, int? memberId, int pointsToRedeem = 0)
    {
        using (SqlConnection conn = db.GetConnection())
        {
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();

            try
            {
                decimal total = items.Sum(x => x.SubTotal);

                SqlCommand cmdInvoice = new SqlCommand(
                @"INSERT INTO Invoices(EmployeeId, MemberId, TotalAmount)
  OUTPUT INSERTED.InvoiceId
  VALUES(@EmployeeId, @MemberId, @Total)", conn, tran);

                cmdInvoice.Parameters.AddWithValue("@EmployeeId", 2);
                cmdInvoice.Parameters.AddWithValue("@MemberId", memberId ?? (object)DBNull.Value);
                cmdInvoice.Parameters.AddWithValue("@Total", total);

                int invoiceId = (int)cmdInvoice.ExecuteScalar();

                SqlCommand cmdPayment = new SqlCommand(
                @"INSERT INTO Payments(InvoiceId,PaymentMethod,AmountPaid)
              VALUES(@InvoiceId,@PaymentMethod,@Amount)", conn, tran);

                cmdPayment.Parameters.AddWithValue("@InvoiceId", invoiceId);
                cmdPayment.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                cmdPayment.Parameters.AddWithValue("@Amount", total);

                cmdPayment.ExecuteNonQuery();

                foreach (var item in items)
                {
                    SqlCommand cmdDetail = new SqlCommand(
                    @"INSERT INTO InvoiceDetails
                  (InvoiceId,ProductId,Quantity,UnitPrice,SubTotal)
                  VALUES(@InvoiceId,@ProductId,@Quantity,@Price,@SubTotal)",
                      conn, tran);

                    cmdDetail.Parameters.AddWithValue("@InvoiceId", invoiceId);
                    cmdDetail.Parameters.AddWithValue("@ProductId", item.ProductId);
                    cmdDetail.Parameters.AddWithValue("@Quantity", item.Quantity);
                    cmdDetail.Parameters.AddWithValue("@Price", item.Price);
                    cmdDetail.Parameters.AddWithValue("@SubTotal", item.SubTotal);

                    cmdDetail.ExecuteNonQuery();
                }

                tran.Commit();

                // Update stock
                UpdateStockAfterInvoice(items);

                // Award points to member based on total (e.g., 1 point per $10)
                if (memberId != null)
                {
                    try
                    {
                        int totalPoints = (int)(total / 10);
                        CustomerService ms = new CustomerService();

                        if (pointsToRedeem > 0)
                        {
                            ms.UsePoints(memberId.Value, pointsToRedeem);
                        }

                        if (totalPoints > 0)
                            ms.AddPoints(memberId.Value, totalPoints);
                    }
                    catch
                    {
                        // non-fatal for invoice, ignore
                    }
                }
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
    }
}