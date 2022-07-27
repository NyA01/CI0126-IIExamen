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

        public double GetTotalAmount(IList<Currency> moneyList)
        {
			double totalAmount = 0;
			foreach (Currency item in moneyList)
			{
				double amount = +item.Amount * item.Value;
				totalAmount = amount + totalAmount;
			}
			return totalAmount;
		}

        public IEnumerable<Currency> GetUserExchange(double exchange, IList<Currency> vendingMachineExchangeList)
        {
			double userExchange=0;
			IList<Currency> userExchangeList = new List<Currency>();
			foreach (Currency item in vendingMachineExchangeList)
            {
				if(item.Amount != 0 && userExchange != exchange)
				{
					int coinsAmount = (int)(exchange/item.Value);
					if(coinsAmount > 0)
					{
						Currency newCoin = new Currency(coinsAmount, item.Name, item.Country, item.Value);
						userExchangeList.Add(newCoin);
						userExchange = coinsAmount * item.Value;
						exchange = exchange % item.Value;
						item.Amount = item.Amount - coinsAmount;
					}
				}
            }
			return userExchangeList.ToList();
		}
    }
}
