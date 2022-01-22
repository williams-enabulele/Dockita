﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dockita.App_Data.Repositories.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        Task InsertAsync(T entity);
        void Update(T entity);
        void Delete(T entity);

        void DeleteRange(IEnumerable<T> entities);
    }
}
