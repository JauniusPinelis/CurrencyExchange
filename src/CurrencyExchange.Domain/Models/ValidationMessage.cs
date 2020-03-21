using CurrencyExchange.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Domain.Models
{
    public class ValidationMessage
    {
        public bool Successful { get; set; }
        public ValidationResponses Message { get; set; }
    }
}
