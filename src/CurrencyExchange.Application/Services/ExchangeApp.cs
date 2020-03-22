using CurrencyExchange.Application.Application;
using CurrencyExchange.Application.Data;
using CurrencyExchange.Domain;
using System;

namespace CurrencyExchange.Application
{
    public class ExchangeApp : IExchange
    {
        private readonly Validator _validator;
        private readonly Parser _parser;
        private readonly Calculator _calculator;
    
        public ExchangeApp(IDataService dataService)
        {
            var currencies =  dataService.GetCurrencyData(); 

            _validator = new Validator(currencies);
            _parser = new Parser(currencies);
            _calculator = new Calculator();
        }

        public string Exchange(string[] input)
        {
            var validation = _validator.Validate(input);

            if (validation.Successful)
            {
                var conversion = _parser.ParseConversion(input);
                return _calculator.Calculate(conversion).ToString();
            }
            else
            {
                return validation.Message.ToString();
            }
        }
    }
}
