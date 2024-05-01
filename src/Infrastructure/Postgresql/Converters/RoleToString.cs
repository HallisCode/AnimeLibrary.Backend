using Domain.RoleRules.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Postgresql.Converters
{
	public class RoleToString : ValueConverter<Role, string>
	{
		public RoleToString() : base(role => role.Name, _string => new Role(_string)) { }
	}
}
