using Database.IQuery.Delete;
using Database.IQuery.Select;
using Domain.Entities.Auth;

namespace Database.IRepositories.Auth
{
	public interface ISessionRepository : IBaseOperations<Session>,
		IQuerySelectAll<Session>, IQueryDeleteAll<Session>
	{

	}
}
