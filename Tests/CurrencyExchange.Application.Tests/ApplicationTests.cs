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

            output.Should().Be("7.4394");
        }
    }
}
