using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.PurchasedProducts.Entities;

namespace Domain.PurchasedProducts.Repositories
{
    public interface IPurchasedProductRepository
    {
        void AddPurchasedProduct(PurchasedProduct productPurchased);
        IEnumerable<PurchasedProduct> GetAllPurchasedProducts();
    }
}
