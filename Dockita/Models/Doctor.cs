using System.Collections.Generic;

namespace Dockita.Models
{
    public class Doctor : BaseEntity
    {
        public string AppUserId { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string Specialty { get; set; }

        public AppUser user { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}