using convenience_store_management_system.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMS.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        //public string Barcode { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Stock { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Status  { get; set; }
        public Product() { }
        public Product(string code, string name, int CategoryId, decimal price, int stock, DateTime expiry, string status)
        {
            ProductId = code;
            ProductName = name;
            CategoryId = CategoryId; 
            Price = price;
            Stock = stock;
            ExpiryDate = expiry;
            Status = status;
        }
        public string DisplayName
        {
            get { return ProductId + " - " + ProductName; }
        }
    }
}
