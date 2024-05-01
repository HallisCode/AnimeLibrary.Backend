using Domain.Entities.Book_;
using Domain.Entities.Creators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Postgresql.Confugirations.Book_
{
	public class BookConfig : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			// Indexes
			builder.HasIndex(book => book.Title).IsUnique();

			// Properties
			builder.Property(book => book.Title).IsRequired().HasMaxLength(256);

			builder.Property(book => book.ISBN13).IsRequired(false).HasMaxLength(13).IsFixedLength(true);

			builder.Property(book => book.YearRelease).IsRequired(false);

			builder.Property(book => book.CountPages).IsRequired(false);

			builder.Property(book => book.Description).IsRequired(false).HasMaxLength(10024);

			// Relationships
			builder.HasOne<Publisher>(book => book.Publisher)
				.WithMany(publisher => publisher.Books)
				.HasForeignKey(book => book.PublisherID)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
