using Domain.Entities.Library;
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
		public Category(string title, ulong? parentCategoryID=null)
		{
			Title = title;

			ParentCategoryID = parentCategoryID;
		}
	}
}
