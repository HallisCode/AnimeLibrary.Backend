using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Domain.AccessSystem.Roles
{
	public  class UserRole
	{
		public static ReadOnlyCollection<RuleName> Premissions = new List<RuleName>()
		{

		}.AsReadOnly();
	}
}
