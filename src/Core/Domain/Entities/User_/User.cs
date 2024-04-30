using Domain.RoleRules.Entities;
using Domain.RoleRules.Enums;

namespace Domain.Entities.User_
{
	public class User : Entity<ulong>
	{
		public string Username { get; set; }

		public Role Role { get; set; }


		// Logic
		private User() { }

		public User(string username)
		{
			Username = username;

			Role = RoleType.User;
		}

	}
}
