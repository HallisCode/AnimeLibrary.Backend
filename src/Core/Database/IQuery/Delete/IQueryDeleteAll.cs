using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.IQuery.Delete
{
    public interface IQueryDeleteAll<TEntity>
    {
        Task DeleteAllByAsync(IEnumerable<TEntity> entities);
    }
}
