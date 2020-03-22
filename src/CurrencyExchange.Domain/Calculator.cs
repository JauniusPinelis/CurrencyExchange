using CurrencyExchange.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Domain
{
    public class Calculator
    {
        private readonly IEnumerable<Currency> _currencies;

        public Calculator(IEnumerable<Currency> currencies)
        {
            _currencies = currencies;
        }

        public decimal Calculate(Conversion conversion)
        {
            throw new NotImplementedException();
        }
    }
}
