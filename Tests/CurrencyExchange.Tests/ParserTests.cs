using CurrencyExchange.Domain;
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
            _parser = new Parser();
        }

        [Test]
        public void ParseConversion_GivenCorrectSyntax_ShouldParseSuccesfully()
        {
            string conversion = "EUR/USD 1";

            var parsedConversion = _parser.ParseConversion(conversion);

            parsedConversion.From.Name.Should().Be("Euro");
            parsedConversion.To.Name.Should().Be("Amerikanske Dollar");
            parsedConversion.Amount.Should().Be(1);
        }

        [Test]
        public void ParseConversion_GivenAmountInSeveralSpaces_ShouldParseSuccesfully()
        {
            string conversion = "EUR/USD 1999";

            var parsedConversion = _parser.ParseConversion(conversion);

            parsedConversion.From.Name.Should().Be("Euro");
            parsedConversion.To.Name.Should().Be("Amerikanske Dollar");
            parsedConversion.Amount.Should().Be(1999);
        }
    }
}
