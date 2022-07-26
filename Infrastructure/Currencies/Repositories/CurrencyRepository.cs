using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Core.Repositories;
using Domain.Currencies.Entities;
using Domain.Currencies;
using Domain.Currencies.Repositories;

namespace Infrastructure.Currencies.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly CurrencyDBContext _dbContext;


        public CurrencyRepository()
        {
            _dbContext = new CurrencyDBContext();
        }

        public IEnumerable<Currency> GetAllCoins()
        {
            IEnumerable<Currency> productList = _dbContext.Coins.Where(e => e.Name == "Colones").ToList();
            return productList;
        }

        public void UpdateCurrencyStock(Currency currency, int amount)
        {
            IEnumerable<Currency> currencyList = _dbContext.Coins.Where(e => e.Value == currency.Value).ToList();
            foreach (Currency element in currencyList)
            {
                element.Amount= currency.Amount - amount;
            }
        }
    }
}
