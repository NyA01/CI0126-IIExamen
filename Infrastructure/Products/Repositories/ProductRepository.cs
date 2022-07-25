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
    }
}
