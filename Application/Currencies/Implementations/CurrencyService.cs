using Domain.Currencies.Entities;
using Domain.Currencies.Repositories;
using System.Collections.Generic;

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
    }
}