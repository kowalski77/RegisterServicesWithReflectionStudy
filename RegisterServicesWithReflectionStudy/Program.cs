using System;
using Microsoft.Extensions.DependencyInjection;

namespace RegisterServicesWithReflectionStudy
{
    internal static class Program
    {
        private static IServiceProvider serviceProvider;

        private static void Main()
        {
            ConfigureServices();
 
            // Do stuff...        
 
            Console.ReadKey();
 
            DisposeServices();
        }


        private static void ConfigureServices()
        {
            var services = new ServiceCollection(); 

            serviceProvider = services.BuildServiceProvider(true);
        }

        private static void DisposeServices()
        {
            switch (serviceProvider)
            {
                case null:
                    return;
                case IDisposable disposable:
                    disposable.Dispose();
                    break;
            }
        }
    }
}