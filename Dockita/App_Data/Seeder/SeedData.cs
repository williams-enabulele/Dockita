using Bogus;
using Dockita.Models;
using System;

namespace Dockita.App_Data.Seeder
{
    public class SeedData
    {
        public SeedData()
        {
            // Using Bogus Package To Generate Dummy Records

            var specialty = new[] { "apple", "banana", "orange", "strawberry", "kiwi" };

            var userFaker = new Faker<AppUser>("en")
                .RuleFor(x => x.Id, x => Guid.NewGuid().ToString())
                .RuleFor(x => x.FirstName, x => x.Person.FirstName)
                .RuleFor(x => x.LastName, x => x.Person.LastName)
                .RuleFor(x => x.Email, (x, y) => x.Internet.Email(y.FirstName, y.LastName))
                .RuleFor(x => x.UserName, x => x.Person.UserName)
                .RuleFor(x => x.UpdatedAt, x => DateTime.Now)
                .RuleFor(x => x.Avatar, x => x.Person.Avatar)
                .RuleFor(x => x.PasswordHash, x => x.Random.Hash());
            //.RuleFor(x => x.Gender, x => x.PickRandom<Gender>());

            var transactionFaker = new Faker<Transaction>();

            var bookingFaker = new Faker<Booking>()
                .RuleFor(x => x.AppUser, x => userFaker)
                .RuleFor(x => x.Id, x => Guid.NewGuid().ToString())
                .RuleFor(x => x.slug, x => x.Hacker.Noun())
                .RuleFor(x => x.Name, x => x.Commerce.ProductName());

            var doctorFaker = new Faker<Doctor>();
            //.RuleFor(x => x.Transactions, x => transactionFaker);
            // .RuleFor( x => x.Specialty, x => x.PickRandom(specialty));

            var paymentFaker = new Faker<Payment>();

            var reviewFaker = new Faker<Review>();
        }
    }
}