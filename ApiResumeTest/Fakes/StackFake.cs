using ApiResume.Domain.Enums;
using ApiResume.Domain.Models;
using Bogus;
using System.Collections.Generic;

namespace ApiResumeTest.Fakes
{
    public struct StackFake
    {
        private const int NUMBER_OF_STACKS = 10;
        private const string LOCALE_LANGUAGE = "pt_BR";

        public static Stack GetStackById(StackIds stackId)
        {
            return new Faker<Stack>(LOCALE_LANGUAGE)
                            .RuleFor(x => x.DateAdded, x => x.Date.Past())
                            .RuleFor(x => x.DateModified, x => x.Date.Past())
                            .RuleFor(x => x.StackId, x => stackId)
                            .RuleFor(x => x.StackName, x => x.Lorem.Slug())
                            .Generate();
        }

        public static Stack GetStack()
        {
            return new Faker<Stack>(LOCALE_LANGUAGE)
                            .RuleFor(x => x.DateAdded, x => x.Date.Past())
                            .RuleFor(x => x.DateModified, x => x.Date.Past())
                            .RuleFor(x => x.StackId, x => (StackIds)x.Random.Number(1, 5))
                            .RuleFor(x => x.StackName, x => x.Lorem.Slug())
                            .Generate();
        }

        public static List<Stack> GetStacks()
        {
            var stacks = new List<Stack>();
            for (int i = 0; i < NUMBER_OF_STACKS; i++)
                stacks.Add(GetStack());

            return stacks;
        }     
    }
}
