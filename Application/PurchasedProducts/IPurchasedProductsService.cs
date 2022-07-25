using Domain.PurchasedProducts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PurchasedProducts
{
    public interface IPurchasedProductsService
    {
        void AddPurchasedProduct(PurchasedProduct productPurchased);
    }
}
