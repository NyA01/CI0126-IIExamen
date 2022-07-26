using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Core.Repositories;
using Domain.Products.Entities;
using Domain.Products;
using Domain.Products.Repositories;

namespace Infrastructure.Products.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDBContext _dbContext;
       

        public ProductRepository()
        {
            _dbContext = new ProductDBContext();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> productList = _dbContext.Products.Where(e => e.Type == "Canned Soda").ToList();                                    
            return productList;
        }

        public void UpdateProductStock(Product product, int amount)
        {
            IEnumerable<Product> productList = _dbContext.Products.Where(e => e.Name == product.Name).ToList();
            foreach(Product element in productList)
            {
                element.Stock = product.Stock - amount;
            }
        }
    }
}
