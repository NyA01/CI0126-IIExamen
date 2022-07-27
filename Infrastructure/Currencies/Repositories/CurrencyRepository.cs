using System.Collections.Generic;
using System.Linq;
using Domain.Currencies.Entities;
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
    }
}
