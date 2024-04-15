using Database.IQuery.Select;
using Domain.Entities.Creators;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.IRepositories.Creators
{
	public interface IPublisherRepository : IBaseOperations<Publisher>, IQuerySelectAllLike<Publisher>
	{

	}
}
