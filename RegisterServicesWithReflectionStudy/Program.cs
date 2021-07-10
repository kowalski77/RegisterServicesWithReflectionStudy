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

            using (var scoped = serviceProvider.CreateScope())
            {
                var startup = scoped.ServiceProvider.GetRequiredService<Startup>();
                startup.Run();    
            }

            Console.ReadKey();
 
            DisposeServices();
        }

        private static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddWhateverServices(typeof(WhateverOne).Assembly);
            services.AddScoped<Startup>();

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