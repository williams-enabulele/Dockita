using Dockita.App_Data.Repositories.Abstractions;
using Dockita.Data;
using Dockita.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dockita.App_Data.Repositories.Implementations
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        private readonly DockitaDBContext _context;
        public ReviewRepository(DockitaDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
