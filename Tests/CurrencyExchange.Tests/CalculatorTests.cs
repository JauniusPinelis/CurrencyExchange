using CurrencyExchange.Domain.Models;
using CurrencyExchange.Domain.Tests.Data;
using FluentAssertions;
using NUnit.Framework;
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
          
            _calculator = new Calculator();
        }

        [Test]
        public void Calculate_GivenEurDKK1_ReturnsCorrectResult()
        {
            var conversion = new Conversion()
            {
                From = new Currency()
                {
                    Name = "Euro",
                    Iso = "EUR",
                    Amount = 743.94M
                },
                To = new Currency()
                {
                    Name = "Danish Kroner",
                    Iso = "DKK",
                    Amount = 100
                },
                Amount = 1
            };

            var amount = _calculator.Calculate(conversion);

            amount.Should().Be(7.4394M);

        }
    }
}
