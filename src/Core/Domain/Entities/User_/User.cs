using Domain.Enums;

namespace Domain.Entities.User_
{
	public class User : Entity<ulong>
	{
		public string Username { get; set; }

		public UserRole Role { get; set; }


		// Logic
		public User(string username)
		{
			Username = username;

			Role = UserRole.User;
		}

	}
}
