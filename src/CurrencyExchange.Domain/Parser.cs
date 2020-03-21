using CurrencyExchange.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyExchange.Domain
{
    public class Parser
    {
        private readonly IEnumerable<Currency> _exchangeRates;
        public Parser(IEnumerable<Currency> exchangeRates)
        {
            _exchangeRates = exchangeRates;
        }

        public Conversion ParseConversion(string conversion)
        {
            string[] components = conversion.Split(' ');
            var currencyCodes = components[0].Split('/');

            var from = _exchangeRates.FirstOrDefault(e => e.Iso == currencyCodes[0]);
            var to = _exchangeRates.FirstOrDefault(e => e.Iso == currencyCodes[1]);
            var amount = int.Parse(components[1]);

            return new Conversion()
            {
                From = from,
                To = to,
                Amount = amount
            };
        }
    }
}
