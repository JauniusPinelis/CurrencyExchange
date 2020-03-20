using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Domain.Models
{
    public class Currency
    {
        public string Name { get; set; }
        public string Iso { get; set; }

        public decimal ExchangeRate { get; set; }
    }
}
