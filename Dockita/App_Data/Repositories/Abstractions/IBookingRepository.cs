using Dockita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dockita.App_Data.Repositories.Abstractions
{
    public interface IBookingRepository : IGenericRepository<Booking>
    {
        IQueryable<Booking> GetBookings(string DoctorId);
        IQueryable<Booking> GetBookingsByUserId(string customerId);
    }
}
