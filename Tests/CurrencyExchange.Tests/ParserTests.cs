using CurrencyExchange.Domain;
using CurrencyExchange.Domain.Models;
using CurrencyExchange.Tests.Shared.Data;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Domain.Tests
{

    public class ParserTests
    {
        private readonly Parser _parser;
        public ParserTests()
        {
            var currencyData = TestData.GetCurrencyData();

            _parser = new Parser(currencyData);
        }

        [Test]
        public void ParseConversion_GivenCorrectSyntax_ShouldParseSuccesfully()
        {
            var input = new string[2] { "EUR/USD", "1" };

            var parsedConversion = _parser.ParseConversion(input);

            parsedConversion.From.Name.Should().Be("Euro");
            parsedConversion.To.Name.Should().Be("Amerikanske dollar");
            parsedConversion.Amount.Should().Be(1);
        }

        [Test]
        public void ParseConversion_GivenAmountInSeveralSpaces_ShouldParseSuccesfully()
        {
            var input = new string[2] { "EUR/USD", "1999" };

            var parsedConversion = _parser.ParseConversion(input);

            parsedConversion.From.Name.Should().Be("Euro");
            parsedConversion.To.Name.Should().Be("Amerikanske dollar");
            parsedConversion.Amount.Should().Be(1999);
        }
    }
}
