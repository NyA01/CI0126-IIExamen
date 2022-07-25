using Domain.PurchasedProducts.Entities;
using Domain.PurchasedProducts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PurchasedProducts.Implementations
{
    public class PurchasedProductService : IPurchasedProductsService
    {
        private readonly IPurchasedProductRepository _purchasedProductRepository;
        public PurchasedProductService(IPurchasedProductRepository purchasedProductRepository)
        {
            _purchasedProductRepository = purchasedProductRepository;
        }

        public void AddPurchasedProduct(PurchasedProduct productPurchased)
        {
            _purchasedProductRepository.AddPurchasedProduct(productPurchased);
        }
    }
}
