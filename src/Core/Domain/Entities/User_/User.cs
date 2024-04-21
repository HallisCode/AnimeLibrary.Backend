using Domain.IEntites.User_;
using Domain.RoleRules.Entities;
using Domain.RoleRules.Enums;

namespace Domain.Entities.User_
{
    public class User : Entity<ulong>, IUser
	{
		public string Username { get; set; }

		public Role Role { get; set; }


		// Logic
		public User(string username)
		{
			Username = username;

			Role = RoleType.User;
		}

	}
}
