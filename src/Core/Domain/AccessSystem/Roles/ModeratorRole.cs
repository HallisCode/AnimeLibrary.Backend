using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.AccessSystem.Roles
{
	public static class ModeratorRole
	{
		public static ReadOnlyCollection<RuleName> Premissions = new List<RuleName>()
		{

		}.AsReadOnly();
	}
}
