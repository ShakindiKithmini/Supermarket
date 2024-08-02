using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace super_market_new
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public double VAT { get; set; }

        public Product(int productID, string category, double price)
        {
            ProductID = productID;
            Category = category;
            Price = price;
            VAT = CalculateVAT();
        }

        public double CalculateVAT()
        {
            if (Price >= 0 && Price >= 100)
            {
                return Price * 0.1;
            }
            else if (Price >= 101 && Price <= 200)
            {
                return Price * 0.2;
            }
            else
            {
                return Price * 0.3;
            }
        }
    }
}
