using Domain.Currencies.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Currencies
{
    public class CurrencyDBContext
    {
        public CurrencyDBContext() { }
        public IList<Currency> Coins = new List<Currency>()
        {
            new Currency(20,"Colones", "CR", 500),
            new Currency(30,"Colones", "CR", 100),
            new Currency(50,"Colones", "CR", 50),
            new Currency(25,"Colones", "CR", 25),
        };
    }
}
