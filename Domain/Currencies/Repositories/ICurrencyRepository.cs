using System.Collections.Generic;
using Domain.Currencies.Entities;

namespace Domain.Currencies.Repositories
{
    public interface ICurrencyRepository
    {
        IEnumerable<Currency> GetAllCoins();
    }
}