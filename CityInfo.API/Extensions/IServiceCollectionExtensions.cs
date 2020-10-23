using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Linq;

namespace CityInfo.API.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection Replace<TService, TImlpementation>(this IServiceCollection services)
        {
            ServiceDescriptor oldServiceDescriptor = services.FirstOrDefault(s => s.ServiceType == typeof(TService));

            if (oldServiceDescriptor == null) { throw new InvalidOperationException($"{typeof(TService).Name} is not registered"); }

            var descriptor = new ServiceDescriptor(typeof(TService), typeof(TImlpementation), oldServiceDescriptor.Lifetime);

            return services.Replace(descriptor);
        }
    }

}
