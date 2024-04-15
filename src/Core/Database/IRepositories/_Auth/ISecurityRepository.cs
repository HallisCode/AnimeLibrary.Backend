using Domain.Entities._Auth;
using System.Threading.Tasks;

namespace Database.IRepositories._Auth
{
    public interface ISecurityRepository
    {
        Task<Security> GetAsync(string email);

        Task<Security> CreateAsync(Security security);

		Task UpdateAsync(Security security);
	}
}
