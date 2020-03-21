using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Application.Application
{
    public interface IExchange
    {
        string Exchange(string input);
    }
}
