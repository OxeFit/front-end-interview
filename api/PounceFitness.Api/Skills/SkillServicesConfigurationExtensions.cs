using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace PounceFitness.Api.Skills
{
    public static class SkillServicesConfigurationExtensions
    {
        public static IServiceCollection AddInMemorySkills(this IServiceCollection services,
            IEnumerable<Skill> skills)
        {
            foreach (var skill in skills)
            {
                services.AddSingleton(skill);
            }

            services.AddSingleton<ISkillRepository, InMemorySkillRepository>();
            return services;
        }
    }
}