using Database.IQuery.Select;
using Domain.Entities.Library;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.IRepositories.Library
{
    public interface IBookRepository : IBaseOperations<Book>, IQuerySelectAllLike<Book>
	{

	}
}
