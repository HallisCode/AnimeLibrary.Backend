using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Database.IQuery.Select
{
    public interface IQuerySelectAll<TEntity>
    {
        Task<List<TEntity>> GetAllByAsync<TKey>(
            Expression<Func<TEntity, bool>> predicate, int take, int offset,
            Expression<Func<TEntity, TKey>> orderBy, params Expression<Func<TEntity, TKey>>[] thenBy
        );


        Task<List<TEntity>> GetAllByAsync(Expression<Func<TEntity, bool>> predicate, int take, int offset);
    }
}
