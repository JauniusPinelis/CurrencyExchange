using CurrencyExchange.Domain.Models;
using CurrencyExchange.Domain.Tests.Data;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CurrencyExchange.Domain.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;
        private IEnumerable<Currency> _currencies;

        public CalculatorTests()
        {
            _currencies = TestData.GetCurrencyData(); 
            _calculator = new Calculator();
        }

        [Test]
        public void Calculate_GivenEuroToDkk_ReturnsCorrectResult()
        {
            var conversion = new Conversion()
            {
                From = _currencies.FirstOrDefault(c => c.Iso == "EUR"),
                To = _currencies.FirstOrDefault(c => c.Iso == "DKK"),
                Amount = 1
            };

            var amount = _calculator.Calculate(conversion);

            amount.Should().Be(7.4394M);

        }

        [Test]
        public void Calculate_GivenEURToUSD_ReturnsCorrectResult()
        {
            var conversion = new Conversion()
            {
                From = _currencies.FirstOrDefault(c => c.Iso == "EUR"),
                To = _currencies.FirstOrDefault(c => c.Iso == "USD"),
                Amount = 10
            };

            var amount = _calculator.Calculate(conversion);

            amount.Should().Be(11.218953114867819818732940236M);

        }
    }
}
