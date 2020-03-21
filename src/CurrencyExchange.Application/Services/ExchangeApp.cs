using CurrencyExchange.Application.Application;
using CurrencyExchange.Application.Data;
using CurrencyExchange.Domain;
using System;

namespace CurrencyExchange.Application
{
    public class ExchangeApp : IExchange
    {
        private readonly IDataService _dataService;

        private readonly Validator _validator;
        private readonly Parser _parser;
    

        public ExchangeApp(IDataService dataService)
        {
            var exchangeRates = _dataService.GetExchangeRates();

            _validator = new Validator(exchangeRates);
            _parser = new Parser(exchangeRates);
           
        }

        public string Exchange(string input)
        {
            throw new NotImplementedException();
        }
    }
}
