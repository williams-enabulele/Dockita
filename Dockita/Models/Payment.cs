using System.Collections.Generic;

namespace Dockita.Models
{
    public class Payment : BaseEntity
    {
        public string BookingId { get; set; }
        public string TransactionReference { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public string MethodOfPayment { get; set; }

        public Booking Booking { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}