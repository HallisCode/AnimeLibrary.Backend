using Domain.Entities.User_;

namespace Application.Context
{
	public interface IUserContext
	{
		bool IsAuthenticated { get; }

		User User { get; }
	}
}
