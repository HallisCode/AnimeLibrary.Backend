using Database.IQuery.Select;
using Domain.Entities.Creators;

namespace Database.IRepositories.Creators
{
	public interface IPublisherRepository : IBaseOperations<Publisher>, IQuerySelectAllLike<Publisher>
	{

	}
}
