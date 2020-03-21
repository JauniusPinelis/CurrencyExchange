using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Domain.Models
{
    public class Conversion
    {
        public Currency From { get; set; }
        public Currency To { get; set; }

        public int Amount { get; set; }
    }
}
