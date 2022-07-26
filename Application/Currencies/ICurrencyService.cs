using Domain.Currencies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Currencies
{
    public interface ICurrencyService
    {
        IEnumerable<Currency> GetAllCoins();
        void UpdateCurrencyStock(Currency currency, int amount);
    }
}