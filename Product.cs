using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Details
{
    public class Product
    {
        public string ProductCode { get; }
        public string ProductName { get; }
        public double Price { get; }
        public string Brand { get; }
        public DateTime ManufacturingDate { get; }
        public DateTime ExpiryDate { get; }

        public Product(string code, string name, double price, string brand, DateTime manufacturingDate, DateTime expiryDate)
        {
            ProductCode = code;
            ProductName = name;
            Price = price;
            Brand = brand;
            ManufacturingDate = manufacturingDate;
            ExpiryDate = expiryDate;
        }
    }
}

