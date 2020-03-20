using CurrencyExchange.Domain;
using System;

namespace CurrencyExchange.Application
{
    public class Application
    {
        private readonly Validator _validator;
        private readonly Converter _converter;

        public Application()
        {
            _validator = new Validator();
            _converter = new Converter();
        }

        public string Convert(string input)
        {

        }
    }
}
