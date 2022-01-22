using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dockita.Models
{
    public class Booking : BaseEntity
    {
        public string AppUserId { get; set; }
    
        public string BookingId { get; set; }
        public string Name { get; set; }
        public Status status { get; set; }

        public AppUser AppUser { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }

    public enum Status
    {
        pending = 0,
        reserved = 1
        
    }
}
