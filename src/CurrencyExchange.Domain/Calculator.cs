using CurrencyExchange.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Domain
{
    public class Calculator
    {        
        public decimal Calculate(Conversion conversion)
        {
            return conversion.Amount * (conversion.From.Amount / 100)
                 / (conversion.To.Amount / 100);
        }
    }
}
