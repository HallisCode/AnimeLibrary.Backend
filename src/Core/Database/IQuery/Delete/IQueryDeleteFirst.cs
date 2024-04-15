using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Database.IQuery.Delete
{
    public interface IQueryDeleteFirst<TEntity>
    {
        Task DeleteFirstByAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
