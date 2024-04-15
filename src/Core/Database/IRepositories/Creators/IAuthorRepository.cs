using Database.IQuery.Select;
using Domain.Entities.Creators;

namespace Database.IRepositories.Creators
{
	public interface IAuthorRepository : IBaseOperations<Author>, IQuerySelectAllLike<Author>
	{

	}
}
