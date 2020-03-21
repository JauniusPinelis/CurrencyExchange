using CurrencyExchange.Application;
using CurrencyExchange.Application.Application;
using CurrencyExchange.Application.Data;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CurrencyExchange.Console
{
    class Program
    {
        private static IServiceProvider _serviceProvider;


        static void Main(string[] args)
        {
            RegisterServices();

            var service = _serviceProvider.GetService<IApplication>();
            service.DoSomething();

            DisposeServices();
        }

      
        private static void RegisterServices()
        {
            var collection = new ServiceCollection();
            collection.AddScoped<IDemoService, DemoService>();
            // ...
            // Add other services
            // ...
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
