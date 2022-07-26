using Domain.Currencies.Entities;
using Domain.PurchasedProducts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.PurchaseCalculator.Implementations
{
	public class PurchaseCalculatorService : IPurchaseCalculatorService
	{
		public PurchaseCalculatorService() { }

		public double GetTotalPurchase(IEnumerable<PurchasedProduct> purchasedProducts)
		{
			double totalPurchase = 0;
			foreach(PurchasedProduct item in purchasedProducts)
			{
				double productPrice =+ item.Amount * item.Price;
				totalPurchase = productPrice + totalPurchase;
			}
			return totalPurchase;
		}

        public double GetUserPayment(IList<Currency> userMoney)
        {
			double totalAmountUserMoney = 0;
			foreach (Currency item in userMoney)
			{
				double userMoneyAmount = +item.Amount * item.Value;
				totalAmountUserMoney = userMoneyAmount + totalAmountUserMoney;
			}
			return totalAmountUserMoney;
		}
    }
}
