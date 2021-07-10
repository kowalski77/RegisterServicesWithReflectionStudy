using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace RegisterServicesWithReflectionStudy
{
    public static class WhateverExtensions
    {
        public static IServiceCollection AddWhateverServices(this IServiceCollection services, Assembly assembly)
        {
            var whateverConcretes = assembly.GetTypes()
                .Where(p => p.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IWhatever<>)))
                .ToList();

            foreach (var concrete in whateverConcretes)
            {
                var interfaceImplemented = concrete.GetInterfaces().First();
                services.Add(new ServiceDescriptor(interfaceImplemented, concrete, ServiceLifetime.Scoped));
            }

            return services;
        }
    }
}