using CurrencyExchange.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Domain.Tests.Data
{
    public static class TestData
    {
        public static IEnumerable<Currency> GetCurrencyData()
        {
            return new List<Currency>() {
                new Currency()
            {
                Name = "Danish Kroner",
                Iso = "DKK",
                Amount= 100M
            },
                new Currency()
            {
                Name = "Euro",
                Iso = "EUR",
                Amount= 743.94M
            },
                new Currency()
            {
                Name = "Amerikanske dollar",
                Iso = "USD",
                Amount= 663.11M
            },
                new Currency()
            {
                Name = "Britiske pund",
                Iso = "GBP",
                Amount= 852.85M
            },
                 new Currency()
            {
                Name = "Svenske kroner",
                Iso = "SEK",
                Amount= 76.10M
            }, new Currency()
            {
                Name = "Norske kroner",
                Iso = "NOK",
                Amount= 78.40M
            },
                 new Currency()
            {
                Name = "Schweiziske franc",
                Iso = "CHF",
                Amount= 683.68M
            },
                 new Currency()
            {
                Name = "Japanske yen",
                Iso = "JPY",
                Amount= 5.9740M
            }};
        }
    }
}
