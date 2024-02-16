using Product_Details;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedList<string, Product> productList = new SortedList<string, Product>();

        // Add five products to the list
        productList.Add("ABC123", new Product("ABC123", "Product1", 10.99, "Brand1", new DateTime(2022, 02, 16), new DateTime(2023, 02, 16)));
        productList.Add("DEF456", new Product("DEF456", "Product2", 15.99, "Brand2", new DateTime(2022, 03, 16), new DateTime(2023, 03, 16)));
        productList.Add("GHI789", new Product("GHI789", "Product3", 20.99, "Brand3", new DateTime(2022, 04, 16), new DateTime(2023, 04, 16)));
        productList.Add("JKL012", new Product("JKL012", "Product4", 25.99, "Brand4", new DateTime(2022, 05, 16), new DateTime(2023, 05, 16)));
        productList.Add("MNO345", new Product("MNO345", "Product5", 30.99, "Brand5", new DateTime(2022, 06, 16), new DateTime(2023, 06, 16)));

        // Display product details
        Console.WriteLine("MfDate\tExpDate\tIndex\tPName\tPrice");
        int index = 1;
        foreach (var product in productList)
        {
            Console.WriteLine($"{product.Value.ManufacturingDate:MM/dd/yyyy}\t{product.Value.ExpiryDate:MM/dd/yyyy}\t{index}\t{product.Value.ProductName}\t{product.Value.Price:C}");
            index++;
        }
    }
}