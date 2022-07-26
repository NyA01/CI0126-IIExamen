using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Currencies.Entities
{
    public class Currency
    {
        public int Amount { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public double Value { get; set; }

        public Currency(int amount, string name, string country, double value)
		{
			Amount = amount;
			Name = name;
			Country = country;
			Value = value;
		}
	}
}