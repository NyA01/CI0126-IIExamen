using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Currencies.Entities;

namespace Domain.Currencies.Repositories
{
    public interface ICurrencyRepository
    {
        IEnumerable<Currency> GetAllCoins();
        void UpdateCurrencyStock(Currency currency, int amount);
    }
}