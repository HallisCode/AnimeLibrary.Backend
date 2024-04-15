using Database.IQuery;
using Database.IQuery.Delete;
using Database.IQuery.Select;
using Domain.Entities.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.IRepositories.User
{
	public interface IMarkedBookRepository : 
		IQuerySelectAll<MarkedBook>, IQueryCreate<MarkedBook>,
		IQueryUpdate<MarkedBook>, IQueryDeleteFirst<MarkedBook>
	{

	}
}
