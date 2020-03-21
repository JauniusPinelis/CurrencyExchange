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
            string[] components = input.Split(' ');
            if (components.Length != 2)
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
