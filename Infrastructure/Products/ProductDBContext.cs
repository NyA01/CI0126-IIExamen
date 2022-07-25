using Domain.Products.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Products
{
    public class ProductDBContext
    {
        public ProductDBContext() { }
        public IList<Product> Products = new List<Product>()
        {
            new Product(10,"Coca Cola", 500, "Canned Soda"),
            new Product(8,"Pepsi", 600, "Canned Soda"),
            new Product(10,"Fanta", 550, "Canned Soda"),
            new Product(15,"Sprite", 725, "Canned Soda"),
        };
    }
}
