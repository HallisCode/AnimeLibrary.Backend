using Domain.RoleRules.Rules;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.RoleRules.Enums.Roles
{
    public static class AdministratorRole
	{
		public static ReadOnlyCollection<Rule> Premissions = new List<Rule>()
		{

		}.AsReadOnly();
	}
}
