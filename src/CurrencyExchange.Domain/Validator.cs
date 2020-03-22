using CurrencyExchange.Domain.Enums;
using CurrencyExchange.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CurrencyExchange.Domain
{
    public class Validator
    {
        private readonly IEnumerable<Currency> _currencies;

        public Validator(IEnumerable<Currency> currencies)
        {
            _currencies = currencies;
            
        }

        public ValidationMessage Validate(string[] input)
        {
            if (input.Length != 2)
            {
                return new ValidationMessage()
                {
                    Successful = false,
                    Message = ValidationResponses.IncorrectFormat
                };
            }

            var currencyCodes = input[0].Split('/');

            if (currencyCodes.Length != 2)
            {
                return new ValidationMessage()
                {
                    Successful = false,
                    Message = ValidationResponses.IncorrectFormat
                };
            }

            if (!int.TryParse(input[1], out _))
            {
                return new ValidationMessage()
                {
                    Successful = false,
                    Message = ValidationResponses.IncorrectFormat
                };
            }

            foreach (var currencyCode in currencyCodes)
            {
                if (!_currencies.Select(c => c.Iso).Contains(currencyCode))
                {
                    return new ValidationMessage()
                    {
                        Successful = false,
                        Message = ValidationResponses.CurrencyNotFound
                    };
                }
            }

            return new ValidationMessage()
            {
                Successful = true,
                Message = ValidationResponses.Success
            };
        }

       
    }
}
