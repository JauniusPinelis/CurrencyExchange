using CurrencyExchange.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyExchange.Domain.Data
{
    public class DataService
    {
        public IEnumerable<Currency> GetExchangeRates()
        {
            return new List<Currency>() {
                new Currency()
            {
                Name = "Euro",
                Iso = "EUR",
                ExchangeRate= 743.94M
            },
                new Currency()
            {
                Name = "Amerikanske dollar",
                Iso = "USD",
                ExchangeRate= 663.11M
            },
                new Currency()
            {
                Name = "Britiske pund",
                Iso = "GBP",
                ExchangeRate= 852.85M
            },
                 new Currency()
            {
                Name = "Svenske kroner",
                Iso = "SEK",
                ExchangeRate= 76.10M
            }, new Currency()
            {
                Name = "Norske kroner",
                Iso = "NOK",
                ExchangeRate= 78.40M
            },
                 new Currency()
            {
                Name = "Schweiziske franc",
                Iso = "CHF",
                ExchangeRate= 683.68M
            },
                 new Currency()
            {
                Name = "Japanske yen",
                Iso = "JPY",
                ExchangeRate= 5.9740M
            }};
        }
    }
}
