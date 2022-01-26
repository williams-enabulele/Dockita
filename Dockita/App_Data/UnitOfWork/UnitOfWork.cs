using Dockita.App_Data.Repositories.Abstractions;
using Dockita.App_Data.Repositories.Implementations;
using Dockita.Data;
using System;
using System.Threading.Tasks;

namespace Dockita.App_Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IBookingRepository _booking;
        private IReviewRepository _review;
        private ITransactionRepository _transaction;
        private IPaymentRepository _payment;
        private IDoctorRepository _doctor;
        private readonly DockitaDBContext _context;

        public UnitOfWork(DockitaDBContext context)
        {
            _context = context;
        }

        public IBookingRepository Booking => _booking ??= new BookingRepository(_context);

        public IReviewRepository Reviews => _review ??= new ReviewRepository(_context);

        public ITransactionRepository Transactions => _transaction ??= new TransactionRepository(_context);

        public IPaymentRepository Payments => _payment ??= new PaymentRepository(_context);

        public IDoctorRepository Doctors => _doctor ??= new DoctorRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}