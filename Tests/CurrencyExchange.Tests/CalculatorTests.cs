using CurrencyExchange.Domain.Models;
using CurrencyExchange.Domain.Tests.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Domain.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;
        public CalculatorTests()
        {
            var currencyRates = TestData.GetCurrencyData();
            _calculator = new Calculator(currencyRates);
        }

        //public void Calculate_GivenEurDKK1_ReturnsCorrectResult()
        //{
        //    var conversion = new Conversion()
        //    {
        //        From = new Currency()
        //        {
        //            Name = "Euro",
        //            Iso = "EUR",
        //            ExchangeRate = 743.94M
        //        }
        //        To = new Currency()
        //        {
        //            Name = "Danish Kroner",
        //            Iso = "EUR",
        //            ExchangeRate = 743.94M
        //        }
        //    }
    }
}
