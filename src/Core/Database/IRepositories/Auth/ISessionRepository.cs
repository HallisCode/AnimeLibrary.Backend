using Database.IQuery;
using Database.IQuery.Delete;
using Database.IQuery.Select;
using Domain.Entities.Auth;
using System.Threading.Tasks;

namespace Database.IRepositories.Auth
{
    public interface ISessionRepository :
        IQuerySelectFirst<Session>, IQuerySelectAll<Session>, IQueryCreate<Session>,
        IQueryDeleteFirst<Session>, IQueryDeleteAll<Session>
    {

    }
}
