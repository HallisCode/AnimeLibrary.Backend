using Domain.Entities.User_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgresql.Converters;

namespace Postgresql.Confugirations.User_
{
	public class UserConfig : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			// Indexes
			builder.HasIndex(user => user.Username).IsUnique();

			// Properties
			builder.Property(user => user.Username).IsRequired().HasMaxLength(32);

			builder.Property(user => user.Role).HasConversion<RoleToString>();
		}
	}
}
