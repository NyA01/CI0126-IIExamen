using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.PurchasedProducts.Entities;

namespace Application.PurchaseCalculator
{
    public interface IPurchaseCalculatorService
    {
        public double GetTotalPurchase(IEnumerable<PurchasedProduct> purchasedProducts);
    }
}

