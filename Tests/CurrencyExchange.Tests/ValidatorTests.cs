using CurrencyExchange.Domain;
using CurrencyExchange.Domain.Data;
using CurrencyExchange.Domain.Enums;
using FluentAssertions;
using NUnit.Framework;

namespace CurrencyExchange.Tests
{
    public class ValidatorTests
    {
        private Validator _validator;
        private DataService _dataService;

        public ValidatorTests()
        {
            _dataService = new DataService();
            var exchangeRates = _dataService.GetExchangeRates();

            _validator = new Validator(exchangeRates);
        }

       
        [Test]
        public void Validate_GivenEmptyString_ValidateIsNotSuccesfull()
        {
            var input = "";

            var message = _validator.Validate(input);

            message.Successful.Should().BeFalse();
        }

        [Test]
        public void Validate_GivenNonExistingCurrency_ValidateIsNotSuccesfull()
        {
            var input = "EUR/LIT 2";

            var message = _validator.Validate(input);

            message.Successful.Should().BeFalse();
            message.Message.Should().Be(ValidationResponses.CurrencyNotFound);
        }

        [Test]
        public void Validate_NoSeparatorInCurrency_WrongFormat()
        {
            var input = "EURSEK 4";

            var message = _validator.Validate(input);

            message.Successful.Should().BeFalse();
            message.Message.Should().Be(ValidationResponses.IncorrectFormat);
        }

        [Test]
        public void Validate_GivenAmountAsWord_WrongFormat()
        {
            var input = "EURSEK four";

            var message = _validator.Validate(input);

            message.Successful.Should().BeFalse();
            message.Message.Should().Be(ValidationResponses.IncorrectFormat);
        }

        [Test]
        public void Validate_OkFormat_Success()
        {
            var input = "EUR/SEK 4";

            var message = _validator.Validate(input);

            message.Successful.Should().BeTrue();
            message.Message.Should().Be(ValidationResponses.Success);
        }
    }
}