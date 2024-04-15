using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Database.IQuery.Delete
{
    public interface IQueryDeleteAll<TEntity>
    {
        Task DeleteAllByAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
