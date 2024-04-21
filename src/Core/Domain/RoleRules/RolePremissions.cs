using System.Collections.Generic;
using System.Collections.ObjectModel;
using Domain.RoleRules.Entities;
using Domain.RoleRules.Enums;
using Domain.RoleRules.Enums.Roles;

namespace Domain.RoleRules
{
	/// <summary>
	/// Отвечает за проверки связанные с Role/Rules.
	/// </summary>
	public static class RolePremissions
	{
		private static Dictionary<Role, ReadOnlyCollection<Rule>> premissions;

		static RolePremissions()
		{
			premissions[RoleType.User] = UserRole.Premissions;

			premissions[RoleType.Moderator] = ModeratorRole.Premissions;

			premissions[RoleType.Administrator] = AdministratorRole.Premissions;
		}


		/// <summary>
		/// Возвращает список всех прав указанной роли <paramref name="role"/>.
		/// </summary>
		public static ReadOnlyCollection<Rule> GetPremissions(Role role)
		{
			return premissions[role];
		}

		/// <summary>
		/// Проверяет, есть ли у роли <paramref name="role"/> указанное право <paramref name="premission"/>.
		/// </summary>
		public static bool IsHasPremission(Role role, Rule premission)
		{
			return premissions[role].Contains(premission);
		}
	}
}
