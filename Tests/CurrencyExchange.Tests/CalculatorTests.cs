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
            var exchangeRates = TestData.GetExchangeRates();
            _calculator = new Calculator(exchangeRates);
        }

        public void Calculate_GivenEurDKK1_ReturnsCorrectResult()
        {
            var conversion = new Conversion()
            {
                from= new 
            }
        }
    }
}
