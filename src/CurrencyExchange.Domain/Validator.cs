using CurrencyExchange.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            string[] components = input.Split(' ');
            if (components.Length != 2)
            {
                return new ValidationMessage()
                {
                    Successful = false,
                    Message = "Incorrect format"
                };
            }

            var currencyCodes = components[0].Split('/');
            if (currencyCodes.Length != 2)
            {
                return new ValidationMessage()
                {
                    Successful = false,
                    Message = "Incorrect format"
                };
            }

            foreach(var currencyCode in currencyCodes)
            {
                if (!_exchangeRates.Select(c => c.Iso).Contains(currencyCode))
                {
                    return new ValidationMessage()
                    {
                        Successful = false,
                        Message = "Currency has not been found"
                    };
                }
            }

            if (!int.TryParse(components[1], out _))
            {
                return new ValidationMessage()
                {
                    Successful = false,
                    Message = "Incorrect format"
                };
            }

            return new ValidationMessage()
            {
                Successful = true,
                Message = "Success"
            };
        }
    }
}
