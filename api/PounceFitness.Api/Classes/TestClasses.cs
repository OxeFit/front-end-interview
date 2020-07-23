using System.Collections.Generic;

namespace PounceFitness.Api.Classes
{
    public static class TestClasses
    {
        public static IEnumerable<Class> Get() => new[]
        {
            new Class
            {
                Name = "Self Defense",
                CatalogNumber = 1.1f 
            },
            new Class
            {
                Name = "Advanced Yoga",
                CatalogNumber = 2.32f 
            },
            new Class
            {
                Name = "Endurance",
                CatalogNumber = 4.17f 
            }
        };
    }
}