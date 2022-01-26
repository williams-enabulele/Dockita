using Dockita.Models;
using System.Linq;

namespace Dockita.App_Data.Repositories.Abstractions
{
    public interface IBookingRepository : IGenericRepository<Booking>
    {
        IQueryable<Booking> GetBookings(string DoctorId);

        IQueryable<Booking> GetBookingsByUserId(string customerId);
    }
}