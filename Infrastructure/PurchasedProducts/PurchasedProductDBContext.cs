using Domain.PurchasedProducts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.PurchasedProducts
{
    public class PurchasedProductDBContext
    {
        public PurchasedProductDBContext() { }
        public IList<PurchasedProduct> PurchasedProducts = new List<PurchasedProduct>()
        {
         
        };
    }
}
