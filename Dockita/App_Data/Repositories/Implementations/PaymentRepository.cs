using Dockita.App_Data.Repositories.Abstractions;
using Dockita.Data;
using Dockita.Models;

namespace Dockita.App_Data.Repositories.Implementations
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        private readonly DockitaDBContext _context;

        public PaymentRepository(DockitaDBContext context) : base(context)
        {
            _context = context;
        }
    }
}