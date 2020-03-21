using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CurrencyExchange.Domain.Enums
{

    public enum ValidationResponses
    {
        [Description("Success")]
        Success,
        [Description("Currency not found")]
        CurrencyNotFound,
        [Description("Incorrect format")]
        IncorrectFormat
    }
}
