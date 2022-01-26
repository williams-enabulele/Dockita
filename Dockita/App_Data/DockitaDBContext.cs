using Dockita.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Dockita.Data
{
    public class DockitaDBContext : IdentityDbContext<AppUser>
    {
        public DockitaDBContext(DbContextOptions<DockitaDBContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries<BaseEntity>())
            {
                switch (item.State)
                {
                    case EntityState.Modified:
                        item.Entity.UpdatedAt = DateTime.UtcNow;
                        break;

                    case EntityState.Added:
                        item.Entity.Id = Guid.NewGuid().ToString();
                        item.Entity.CreatedAt = DateTime.UtcNow;
                        break;

                    default:
                        break;
                }
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}