using Database.IQuery;
using Database.IQuery.Delete;
using Database.IQuery.Select;
using Domain.Entities.UserData;

namespace Database.IRepositories.User_
{
	public interface IMarkedBookRepository : 
		IQuerySelectAll<MarkedBook>, IQueryCreate<MarkedBook>,
		IQueryUpdate<MarkedBook>, IQueryDeleteFirst<MarkedBook>
	{

	}
}
