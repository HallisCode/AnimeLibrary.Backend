using Database.IQuery.Select;
<<<<<<< HEAD
using Domain.Entities.BookData;
=======
using Domain.Entities.Aggregates;
>>>>>>> 90dcce8 (Database. Ренейминг импорта)
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.IRepositories.Library
{
    public interface IBookRepository : IBaseOperations<Book>, IQuerySelectAllLike<Book>
	{

	}
}
