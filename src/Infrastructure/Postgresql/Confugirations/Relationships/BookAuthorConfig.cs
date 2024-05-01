using Domain.Entities.Book_;
using Domain.Entities.Creators;
using Domain.Entities.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Postgresql.Confugirations.Relationships
{
	public class BookAuthorConfig : IEntityTypeConfiguration<BookAuthor>
	{
		public void Configure(EntityTypeBuilder<BookAuthor> builder)
		{
			// Keys
			builder.HasKey(bookAuthor => new { bookAuthor.AuthorID, bookAuthor.BookID });

			// Relationships
			builder.HasOne<Author>(bookAuthor => bookAuthor.Author)
				.WithMany(author => author.BookAuthors)
				.HasForeignKey(bookAuthor => bookAuthor.AuthorID);

			builder.HasOne<Book>(bookAuthor => bookAuthor.Book)
				.WithMany(book => book.BookAuthors)
				.HasForeignKey(bookAuthor => bookAuthor.BookID);
		}
	}
}
