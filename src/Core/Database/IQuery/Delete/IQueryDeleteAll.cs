﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.IQuery.Delete
{
    public interface IQueryDeleteAll<TEntity>
    {
        Task DeleteAllAsync(IEnumerable<TEntity> entities);
    }
}
