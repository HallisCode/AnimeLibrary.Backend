using Database.IQuery.Select;
using Domain.Entities.Classification;

namespace Database.IRepositories.Classification
{
	public interface ICategoryRepository : IBaseOperations<Category>, IQuerySelectAllLike<Category>
	{

	}
}
