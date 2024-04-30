using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Database.IQuery.Select
{
	public interface IQuerySelectFirst<TEntity>
	{
		Task<TEntity> GetFirstByAsync(Expression<Func<TEntity, bool>> predicate);
	}
}
