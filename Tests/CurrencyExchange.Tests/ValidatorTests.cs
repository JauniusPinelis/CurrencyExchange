using CurrencyExchange.Domain;
using CurrencyExchange.Domain.Data;
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

            message.Successfull.Should().BeFalse();
        }
    }
}