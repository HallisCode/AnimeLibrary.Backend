using Domain.Entities.Creators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Postgresql.Confugirations.Creators
{
	public class AuthorConfig : IEntityTypeConfiguration<Author>
	{
		public void Configure(EntityTypeBuilder<Author> builder)
		{
			// Keys
			builder.HasKey(author => author.ID);

			// Indexes
			builder.HasIndex(author => author.Name);

			builder.HasIndex(author => author.LastName);

			// Properties
			builder.Property(author => author.Name).HasMaxLength(32);

			builder.Property(author => author.LastName).HasMaxLength(32);

			builder.Property(author => author.Description).HasMaxLength(10024);
		}
	}
}
