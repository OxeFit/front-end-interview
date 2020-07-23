using System.Collections.Generic;

namespace PounceFitness.Api.Skills
{
    public static class TestSkills
    {
        public static IEnumerable<Skill> Get() => new[]
        {
            new Skill
            {
                Name = "Strike",
                Description = "A directed physical attack with part of the human body or with an object, " +
                              "intended to cause blunt trauma or penetrating trauma upon an opponent"
            },
            new Skill
            {
                Name = "Block"
            },
            new Skill
            {
                Name = "Counter Punch"
            }
        };
    }
}