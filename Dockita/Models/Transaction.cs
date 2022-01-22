using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dockita.Models
{
    public class Transaction : BaseEntity
    {
        public string DoctorId { get; set; }
        public string UserId { get; set; }
        public string PaymentId { get; set; }

        public Doctor Doctor { get; set; }
        public AppUser AppUser { get; set; }
        public Booking Booking { get; set; }
        public Payment Payment { get; set; }

    }
}
