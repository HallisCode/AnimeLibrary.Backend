using Domain.Entities.Book_;
using Domain.Entities.User_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Postgresql.Confugirations.Book_
{
	public class ReviewConfig : IEntityTypeConfiguration<Review>
	{
		public void Configure(EntityTypeBuilder<Review> builder)
		{
			// Keys
			builder.HasKey(review => new { review.UserID, review.BookID });

			// Properties
			builder.Property(review => review.Content).IsRequired().HasMaxLength(5012);

			// Relationships
			builder.HasOne<User>(review => review.User)
				.WithMany()
				.HasForeignKey(review => review.UserID)
				.IsRequired()
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne<Book>(review => review.Book)
				.WithMany()
				.HasForeignKey(review => review.BookID)
				.IsRequired()
				.OnDelete(DeleteBehavior.Cascade);

		}
	}
}
