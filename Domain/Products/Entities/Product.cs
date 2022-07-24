using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Products.Entities
{
    public class Product
    {
        public int Stock { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

        public Product(int stock, string name, double price, string type)
        {
            Stock = stock;
            Name = name;
            Price = price;
            Type = type;
        }
    }
}
