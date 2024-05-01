using Domain.Entities.Auth;
using Domain.Entities.User_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Postgresql.Confugirations.Auth
{
	public class SecurityConfig : IEntityTypeConfiguration<Security>
	{
		public void Configure(EntityTypeBuilder<Security> builder)
		{
			// Keys
			builder.HasKey(security => security.ID);

			// Indexes
			builder.HasIndex(security => security.Email).IsUnique();

			// Properties
			builder.Property(security => security.Email).IsRequired().HasMaxLength(128);

			builder.Property(security => security.Password).IsRequired().HasMaxLength(128);

			// Relationships
			builder.HasOne<User>()
				.WithOne()
				.HasForeignKey<Security>(security => security.UserID)
				.IsRequired()
				.OnDelete(DeleteBehavior.Cascade);


		}
	}
}
