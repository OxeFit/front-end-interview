using System.Collections.Generic;

namespace PounceFitness.Api.Skills
{
    public static class TestSkills
    {
        public static IEnumerable<Skill> Get() => new[]
        {
            new Skill
            {
                Id = "1",
                Name = "Strike",
                Description = "A directed physical attack with part of the human body or with an object, " +
                              "intended to cause blunt trauma or penetrating trauma upon an opponent"
            },
            new Skill
            {
                Id = "2",
                Name = "Block"
            },
            new Skill
            {
                Id = "3",
                Name = "Counter Punch"
            }
        };
    }
}