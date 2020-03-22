using CurrencyExchange.Application;
using CurrencyExchange.Application.Application;
using CurrencyExchange.Application.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CurrencyExchange.Console
{
    public class Program
    {
        private static IServiceProvider _serviceProvider;


        static void Main(string[] args)
        {
            RegisterServices();

            var exchangeService = _serviceProvider.GetService<IExchange>();
            exchangeService.Exchange(args);

            DisposeServices();
        }

      
        private static void RegisterServices()
        {
            var collection = new ServiceCollection();
            collection.AddScoped<IDataService, DataService>();
            collection.AddScoped<IExchange, ExchangeApp>();

            _serviceProvider = collection.BuildServiceProvider();
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
