using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dockita.Models
{
    public class Review : BaseEntity
    {
        public string Comment { get; set; }
        public double Rating { get; set; }
        public string AppUserId { get; set; }
        public string DoctorId { get; set; }

        public Doctor Doctor { get; set; }
        public AppUser AppUser { get; set; }
    }
}
