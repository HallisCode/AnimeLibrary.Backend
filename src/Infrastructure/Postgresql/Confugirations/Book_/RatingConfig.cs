using Domain.Entities.Book_;
using Domain.Entities.User_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Postgresql.Converters;


namespace Postgresql.Confugirations.Book_
{
	public class RatingConfig : IEntityTypeConfiguration<Rating>
	{
		public void Configure(EntityTypeBuilder<Rating> builder)
		{
			// Keys
			builder.HasKey(rating => new { rating.UserID, rating.BookID });

			// Properties
			builder.Property(rating => rating.Score).IsRequired().HasConversion<DecimalRatingToByte>();


			// Relationships
			builder.HasOne<User>()
				.WithMany()
				.HasForeignKey(rating => rating.UserID)
				.IsRequired()
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasOne<Book>()
				.WithMany()
				.HasForeignKey(rating => rating.BookID)
				.IsRequired()
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
