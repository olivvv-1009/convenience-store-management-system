using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using convenience_store_management_system.Models;
using CSMS.Database;
using CSMS.Repositories;


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

    public void CreateInvoice(List<CartItem> items, string paymentMethod, int? memberId)
    {
        using (SqlConnection conn = db.GetConnection())
        {
            conn.Open();
            SqlTransaction tran = conn.BeginTransaction();

            try
            {
                decimal total = items.Sum(x => x.SubTotal);

                SqlCommand cmdInvoice = new SqlCommand(
                @"INSERT INTO Invoices(UserId,MemberId,TotalAmount)
              OUTPUT INSERTED.InvoiceId
              VALUES(@UserId,@MemberId,@Total)", conn, tran);

                cmdInvoice.Parameters.AddWithValue("@UserId", 2);
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

                UpdateStockAfterInvoice(items);
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
    }
}