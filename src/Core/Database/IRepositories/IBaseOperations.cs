using Database.IQuery;
using Database.IQuery.Delete;
using Database.IQuery.Select;

namespace Database.IRepositories
{
	public interface IBaseOperations<TEntity> :
		IQuerySelectFirst<TEntity>, IQueryCreate<TEntity>,
		IQueryUpdate<TEntity>, IQueryDeleteFirst<TEntity>
	{
	}
}
