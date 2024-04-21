using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.RoleRules.Enums.Roles
{
    public static class ModeratorRole
	{
		public static ReadOnlyCollection<Rule> Premissions = new List<Rule>()
		{

		}.AsReadOnly();
	}
}
