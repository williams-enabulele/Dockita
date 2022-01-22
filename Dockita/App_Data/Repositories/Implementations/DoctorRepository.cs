using Dockita.App_Data.Repositories.Abstractions;
using Dockita.Data;
using Dockita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dockita.App_Data.Repositories.Implementations
{
    public class DoctorRepository :GenericRepository<Doctor>,IDoctorRepository
    {
        private readonly DockitaDBContext _context;
        public DoctorRepository(DockitaDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
