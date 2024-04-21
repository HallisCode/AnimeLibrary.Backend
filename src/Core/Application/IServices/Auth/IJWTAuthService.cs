using Application.DTO.Auth;
using System.Threading.Tasks;

namespace Application.IServices.Auth
{
	public interface IJWTAuthService
	{
		Task<SignInResponse> SignInAsync(SignInRequest request);

		Task SignOutAsync(SignOutReuqest reuqest);

		Task<AccessToken> GetAccessTokenAsync(GetAccessTokenRequest request);

		Task<bool> VerifyAccessTokenAsync(AccessToken token);
	}
}
