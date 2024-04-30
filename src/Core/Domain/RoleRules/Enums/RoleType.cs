using Domain.RoleRules.Entities;

namespace Domain.RoleRules.Enums
{
	public static class RoleType
	{
		public static readonly Role User = new Role(nameof(User));

		public static readonly Role Moderator = new Role(nameof(Moderator));

		public static readonly Role Administrator = new Role(nameof(Administrator));
	}
}
