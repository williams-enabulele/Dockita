using Dockita.App_Data.Repositories.Abstractions;
using Dockita.Data;
using Dockita.Models;
using System;
using System.Linq;

namespace Dockita.App_Data.Repositories.Implementations
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        private readonly DockitaDBContext _context;

        public BookingRepository(DockitaDBContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Booking> GetBookings(string managerId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Booking> GetBookingsByUserId(string customerId)
        {
            throw new NotImplementedException();
        }
    }
}