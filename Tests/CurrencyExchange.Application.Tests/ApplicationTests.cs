using CurrencyExchange.Application.Application;
using CurrencyExchange.Application.Data;
using CurrencyExchange.Tests.Shared.Data;
using Moq;
using FluentAssertions;
using NUnit.Framework;

namespace CurrencyExchange.Application.Tests
{
    public class ApplicationTests
    {
        private readonly IExchange _exchangeApplication;
        public ApplicationTests()
        {
            var mockDataService = new Mock<IDataService>();
            mockDataService.Setup(m => m.GetCurrencyData())
                  .Returns(TestData.GetCurrencyData());

            _exchangeApplication = new ExchangeApp(mockDataService.Object);
        }

        [Test]
        public void Exchange_GivenValidInput_CorrectCalculationIsReturned()
        {
            var input = new string[2] { "EUR/DKK", "1" };

            var output = _exchangeApplication.Exchange(input);

            output.Should().Be("7,4394");
        }

        [Test]
        public void Exchange_GivenNoInput_ReturnsIncorrectFormat()
        {
            var input = new string[0];

            var output = _exchangeApplication.Exchange(input);

            output.Should().Be("Incorrect format");
        }

        [Test]
        public void Exchange_GivenEmptyString_ReturnsIncorrectFormat()
        {
            var input = new string[2] {"","" };

            var output = _exchangeApplication.Exchange(input);

            output.Should().Be("Incorrect format");
        }

        [Test]
        public void Exchange_NonExistingCurrency_ReturnsIncorrectFormat()
        {
            var input = new string[2] { "EUR/DULL", "3" };

            var output = _exchangeApplication.Exchange(input);

            output.Should().Be("Currency not found");
        }

        [Test]
        public void Exchange_SameCurrency_ReturnsTheSameAmount()
        {
            var input = new string[2] { "GBP/GBP", "3" };

            var output = _exchangeApplication.Exchange(input);

            output.Should().Be("3");
        }

        [Test]
        public void Exchange_EurToUsd_ReturnsCorrectAmount()
        {
            var input = new string[2] { "EUR/USD", "10" };

            var output = _exchangeApplication.Exchange(input);

            output.Should().Be("11,218953114867819818732940236");

        }
    }
}
