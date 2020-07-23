using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace PounceFitness.Api.Classes
{
    public static class ClassServicesConfigurationExtensions
    {
        public static IServiceCollection AddInMemoryClasses(this IServiceCollection services,
            IEnumerable<Class> classes)
        {
            foreach (var @class in classes)
            {
                services.AddSingleton(@class);
            }

            services.AddSingleton<IClassRepository, InMemoryClassRepository>();
            return services;
        }
    }
}