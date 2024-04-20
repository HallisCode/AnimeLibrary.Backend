using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Domain.AccessSystem
{
	public static class RolePremissions
	{
		private static Dictionary<Enums.UserRole, ReadOnlyCollection<RuleName>> premissions;

		static RolePremissions()
		{
			premissions[Enums.UserRole.User] = Roles.UserRole.Premissions;

			premissions[Enums.UserRole.Moderator] = Roles.ModeratorRole.Premissions;

			premissions[Enums.UserRole.Admin] = Roles.AdminRole.Premissions;
		}

		public static ReadOnlyCollection<RuleName> GetPremissions(Enums.UserRole role)
		{
			return premissions[role];
		}

		public static bool IsHasPremission(Enums.UserRole role, RuleName premission)
		{
			return premissions[role].Contains(premission);
		}
	}
}
