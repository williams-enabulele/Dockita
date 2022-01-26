using Dockita.App_Data.Repositories.Abstractions;
using Dockita.Data;
using Dockita.Models;

namespace Dockita.App_Data.Repositories.Implementations
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        private readonly DockitaDBContext _context;

        public DoctorRepository(DockitaDBContext context) : base(context)
        {
            _context = context;
        }
    }
}