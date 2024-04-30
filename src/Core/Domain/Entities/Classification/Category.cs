using Domain.Entities.Book_;
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
		private Category() { }

		public Category(string title, ulong? parentCategoryID = null)
		{
			Title = title;

			ParentCategoryID = parentCategoryID;

		}

		public void Update(string title = null, ulong? parentCategoryID = null)
		{
			if (title is not null) Title = title;

			if (parentCategoryID is not null) ParentCategoryID = parentCategoryID;

		}
	}
}
