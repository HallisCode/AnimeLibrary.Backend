using Domain.Entities.Creators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Postgresql.Confugirations.Creators
{
	public class PublisherConfig : IEntityTypeConfiguration<Publisher>
	{
		public void Configure(EntityTypeBuilder<Publisher> builder)
		{
			// Keys
			builder.HasKey(publisher => publisher.ID);

			// Indexes
			builder.HasIndex(publisher => publisher.Name);

			// Properties
			builder.Property(publisher => publisher.Name).IsRequired().HasMaxLength(32);
		}
	}
}
