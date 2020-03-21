﻿using CurrencyExchange.Domain;
using CurrencyExchange.Domain.Data;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Tests
{

    public class ParserTests
    {
        private readonly Parser _parser;
        public ParserTests()
        {
            var dataService = new DataService();
            var exchangeRates = dataService.GetExchangeRates();

            _parser = new Parser(exchangeRates);
        }

        [Test]
        public void ParseConversion_GivenCorrectSyntax_ShouldParseSuccesfully()
        {
            string conversion = "EUR/USD 1";

            var parsedConversion = _parser.ParseConversion(conversion);

            parsedConversion.From.Name.Should().Be("Euro");
            parsedConversion.To.Name.Should().Be("Amerikanske dollar");
            parsedConversion.Amount.Should().Be(1);
        }

        [Test]
        public void ParseConversion_GivenAmountInSeveralSpaces_ShouldParseSuccesfully()
        {
            string conversion = "EUR/USD 1999";

            var parsedConversion = _parser.ParseConversion(conversion);

            parsedConversion.From.Name.Should().Be("Euro");
            parsedConversion.To.Name.Should().Be("Amerikanske dollar");
            parsedConversion.Amount.Should().Be(1999);
        }
    }
}
