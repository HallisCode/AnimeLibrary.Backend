using Application.DTO.Auth;
using System.Threading.Tasks;

namespace Application.IServices.Auth
{
	public interface ISecurityService
	{
		Task ChangePasswordAsync(ChangePasswordRequest request);
	}
}
