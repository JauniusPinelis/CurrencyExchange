using CurrencyExchange.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Domain
{
    public class Calculator
    {
        private readonly IEnumerable<Currency> _exchangeRates;

        public Calculator(IEnumerable<Currency> exchangeRates)
        {
            _exchangeRates = exchangeRates;
        }

        public decimal Calculate(Conversion conversion)
        {
            throw new NotImplementedException();
        }
    }
}
