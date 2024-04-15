using Domain.Entities._Auth;
using System.Threading.Tasks;

namespace Database.IRepositories._Auth
{
	public interface ISessionRepository
	{
		Task AppearAsync(string guid);

		Task<Session> GetAsync(string guid);

		Task<Session> CreateAsync(Session session);

		Task DeleteAsync(string guid);

		Task DeleteAllByAsync(long userID);
	}
}
