using Database.IQuery.Select;
using Domain.Entities.BookData;

namespace Database.IRepositories.Book_
{
    public interface IBookRepository : IBaseOperations<Book>, IQuerySelectAllLike<Book>
	{

	}
}
