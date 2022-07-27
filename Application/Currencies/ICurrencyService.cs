using Domain.Currencies.Entities;
using System.Collections.Generic;

namespace Application.Currencies
{
    public interface ICurrencyService
    {
        IEnumerable<Currency> GetAllCoins();
    }
}