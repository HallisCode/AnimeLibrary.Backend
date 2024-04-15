using Database.IQuery.Delete;
using Database.IQuery.Select;
using Database.IQuery;

namespace Database.IRepositories
{
	public interface IBaseOperations<TEntity> :
		IQuerySelectFirst<TEntity>, IQueryCreate<TEntity>,
		IQueryUpdate<TEntity>, IQueryDeleteFirst<TEntity>
	{
	}
}
