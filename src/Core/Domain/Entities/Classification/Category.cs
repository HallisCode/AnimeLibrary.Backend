using Domain.Entities.Book_;
using Domain.Validation.Models;
using FluentValidation;
using System.Collections.Generic;


namespace Domain.Entities.Classification
{
	public class Category : Entity<ulong>
	{
		public string Title { get; private set; }


		// Relationships
		public ulong? ParentCategoryID { get; private set; }

		// Navigations links
		public Category ParentCategory { get; private set; }

		public IList<Category> SubCategories { get; private set; }

		public IList<Book> Books { get; private set; }


		// Logic
		public Category(string title, ulong? parentCategoryID = null)
		{
			Title = title;

			ParentCategoryID = parentCategoryID;

			Validate();
		}

		public void Update(string title = null, ulong? parentCategoryID = null)
		{
			if (title is not null) Title = title;

			if (parentCategoryID is not null) ParentCategoryID = parentCategoryID;

			Validate();
		}

		protected override void Validate()
		{
			IValidator<Category> validator = new CategoryValidator();

			validator.ValidateAndThrow(this);
		}
	}
}
