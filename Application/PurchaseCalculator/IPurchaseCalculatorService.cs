using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Currencies.Entities;
using Domain.PurchasedProducts.Entities;

namespace Application.PurchaseCalculator
{
    public interface IPurchaseCalculatorService
    {
        public double GetTotalPurchase(IEnumerable<PurchasedProduct> purchasedProducts);
        public double GetUserPayment(IList<Currency> userMoney);
    }
}

