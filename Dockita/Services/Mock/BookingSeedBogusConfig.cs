using AutoBogus;
using Bogus;
using System;

namespace JobHut.Infrastructure.Shared.Mock
{
   /* public class BookingSeedBogusConfig : AutoFaker<Position>
    {
        public BookingSeedBogusConfig()
        {
            Randomizer.Seed = new Random(8675309);

            RuleFor(m => m.Id, f => Guid.NewGuid());
            RuleFor(o => o.PositionTitle, f => f.Name.JobTitle());
            RuleFor(o => o.PositionNumber, f => f.Commerce.Ean13());
            RuleFor(o => o.PositionDescription, f => f.Name.JobDescriptor());
            RuleFor(o => o.PositionSalary, f => f.Finance.Amount());
        }
    }*/
}