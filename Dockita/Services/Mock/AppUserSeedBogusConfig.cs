using AutoBogus;
using Bogus;
using Dockita.Models;
using System;
using static Dockita.Shared.Enums;

namespace Dockita.Services.Mock
{
    public class AppUserSeedBogusConfig : AutoFaker<AppUser>
    {
       /* public AppUserSeedBogusConfig() 
        {
            Randomizer.Seed = new Random(8675309);
            .RuleFor(x => x.Id, x => Guid.NewGuid().ToString())
            .RuleFor(x => x.FirstName, x => x.Person.FirstName)
            .RuleFor(x => x.LastName, x => x.Person.LastName)
            .RuleFor(x => x.Email, (x, y) => x.Internet.Email(y.FirstName, y.LastName))
            .RuleFor(x => x.UserName, x => x.Person.UserName)
            .RuleFor(x => x.UpdatedAt, x => DateTime.Now)
            .RuleFor(x => x.Avatar, x => x.Person.Avatar)
            .RuleFor(x => x.PasswordHash, x => x.Random.Hash())
            .RuleFor(x => x.Gender, x => x.PickRandom<Gender>());
        }*/
    }
}