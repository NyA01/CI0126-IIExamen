using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Core.Repositories;
using Domain.PurchasedProducts.Entities;
using Domain.Products;
using Domain.PurchasedProducts.Repositories;
using Infrastructure.PurchasedProducts;

namespace Infrastructure.Products.Repositories
{
    public class PurchasedProductRepository : IPurchasedProductRepository
    {
        private readonly PurchasedProductDBContext _dbContext;

        public PurchasedProductRepository()
        {
            _dbContext = new PurchasedProductDBContext();
        }

        public void AddPurchasedProduct(PurchasedProduct productPurchased)
        {
            _dbContext.PurchasedProducts.Add(productPurchased);
        }

        public IEnumerable<PurchasedProduct> GetAllPurchasedProducts()
        {
            
            IEnumerable<PurchasedProduct> productList = _dbContext.PurchasedProducts.Where(e => e.Type == "Canned Soda").ToList();
            return productList;
            
        }
    }
}
