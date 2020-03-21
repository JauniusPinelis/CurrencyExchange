using CurrencyExchange.Domain;
using CurrencyExchange.Domain.Data;
using System;

namespace CurrencyExchange.Application
{
    public class Application
    {
        private readonly DataService _dataService;
        private readonly Validator _validator;
        private readonly Converter _converter;

        public Application()
        {
            _dataService = new DataService();
            var exchangeRates = _dataService.GetExchangeRates();

            _validator = new Validator(exchangeRates);
            //_converter = new Converter();
        }

      
    }
}
