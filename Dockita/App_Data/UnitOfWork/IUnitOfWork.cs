using Dockita.App_Data.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dockita.App_Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {

        IBookingRepository Booking { get; }
        IReviewRepository Reviews { get; }
        ITransactionRepository Transactions { get; }
        IPaymentRepository Payments { get; }
        IDoctorRepository Doctors { get; }
        Task Save();
    }
}
