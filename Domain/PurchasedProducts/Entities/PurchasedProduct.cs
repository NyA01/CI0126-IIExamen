using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.PurchasedProducts.Entities
{
    public class PurchasedProduct
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

        public PurchasedProduct(string name, int amount, double price, string type)
        {
            Name = name;
            Price = price;
            Amount = amount;
            Type = type;
        }
    }
}
