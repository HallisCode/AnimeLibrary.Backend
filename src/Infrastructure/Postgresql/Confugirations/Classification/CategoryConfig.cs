using Domain.Entities.Book_;
using Domain.Entities.Classification;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Postgresql.Confugirations.Classification
{
	public class CategoryConfig : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			// Keys
			builder.HasKey(category => category.ID);

			// Indexes
			builder.HasIndex(category => category.Title).IsUnique();

			// Properties
			builder.Property(category => category.Title).IsRequired().HasMaxLength(32);

			// Relationships
			builder.HasOne<Category>(category => category.ParentCategory)
				.WithMany(category => category.SubCategories)
				.HasForeignKey(category => category.ParentCategoryID)
				.OnDelete(DeleteBehavior.SetNull);

			builder.HasMany<Book>(category => category.Books)
				.WithMany(book => book.Categories);
		}
	}
}
