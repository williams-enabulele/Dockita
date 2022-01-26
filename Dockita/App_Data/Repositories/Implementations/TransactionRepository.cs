using Dockita.App_Data.Repositories.Abstractions;
using Dockita.Data;
using System.Transactions;

namespace Dockita.App_Data.Repositories.Implementations
{
    public class TransactionRepository : GenericRepository<Transaction>, ITransactionRepository
    {
        private readonly DockitaDBContext _context;

        public TransactionRepository(DockitaDBContext context) : base(context)
        {
            _context = context;
        }
    }
}