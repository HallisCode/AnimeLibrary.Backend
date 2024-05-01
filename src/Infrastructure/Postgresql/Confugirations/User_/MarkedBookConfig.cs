using Domain.Entities.Book_;
using Domain.Entities.User_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Postgresql.Confugirations.User_
{
	public class MarkedBookConfig : IEntityTypeConfiguration<MarkedBook>
	{
		public void Configure(EntityTypeBuilder<MarkedBook> builder)
		{
			// Keys
			builder.HasKey(markedBook => new { markedBook.UserID, markedBook.BookID });

			// Properties
			builder.Property(markedBook => markedBook.Status).IsRequired();

			// Relationships
			builder.HasOne<Book>(markedBook => markedBook.Book)
				.WithMany()
				.HasForeignKey(markedBook => markedBook.BookID)
				.IsRequired();

			builder.HasOne<User>(user => user.User)
				.WithMany()
				.HasForeignKey(user => user.UserID)
				.IsRequired();
		}
	}
}
