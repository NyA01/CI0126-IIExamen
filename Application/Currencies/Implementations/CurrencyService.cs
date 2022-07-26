using Domain.Currencies.Entities;
using Domain.Currencies.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Currencies.Implementations
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;
        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public IEnumerable<Currency> GetAllCoins()
        {
            return _currencyRepository.GetAllCoins(); ;
        }

        public void UpdateCurrencyStock(Currency currency, int amount)
        {
            _currencyRepository.UpdateCurrencyStock(currency, amount);
        }
    }
}