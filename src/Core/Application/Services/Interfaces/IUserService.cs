using Application.DTO.ReturningType;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
	public interface IUserService
	{
		Task<OperationResult> ChangeUsernameAsdync();
	}
}
