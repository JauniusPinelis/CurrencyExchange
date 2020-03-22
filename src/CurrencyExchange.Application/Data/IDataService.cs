using CurrencyExchange.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyExchange.Application.Data
{
    public interface IDataService
    {
        IEnumerable<Currency> GetCurrencyData();
    }
}
