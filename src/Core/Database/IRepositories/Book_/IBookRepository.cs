using Database.IQuery.Select;
using Domain.Entities.Book_;

namespace Database.IRepositories.Book_
{
	public interface IBookRepository : IBaseOperations<Book>, IQuerySelectAllLike<Book>
	{

	}
}
