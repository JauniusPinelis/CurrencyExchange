using CurrencyExchange.Domain.Models;
using System;
using System.Collections.Generic;

namespace CurrencyExchange.Domain
{
    public class Validator
    {
        private readonly IEnumerable<Currency> _exchangeRates;

        public Validator(IEnumerable<Currency> exchangeRates)
        {
            _exchangeRates = exchangeRates;
        }

        public ValidationMessage Validate(string input)
        {
            throw new NotImplementedException();
        }
    }
}
