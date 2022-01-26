using System.Collections.Generic;
using static Dockita.Shared.Enums;

namespace Dockita.Models
{
    public class Booking : BaseEntity
    {
        public string AppUserId { get; set; }

        public string slug { get; set; }
        public string Name { get; set; }
        public Status status { get; set; }

        public AppUser AppUser { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}