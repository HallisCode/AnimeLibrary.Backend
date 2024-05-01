using Domain.Entities.Auth;
using Domain.Entities.User_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Postgresql.Confugirations.Auth
{
	public class SessionConfig : IEntityTypeConfiguration<Session>
	{
		public void Configure(EntityTypeBuilder<Session> builder)
		{
			// Properties
			builder.Property(security => security.AppName).IsRequired().HasMaxLength(128);

			// Relationships
			builder.HasOne<User>()
				.WithMany()
				.HasForeignKey(session => session.UserID)
				.IsRequired()
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
