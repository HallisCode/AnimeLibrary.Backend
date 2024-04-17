using Domain.Entities.Library;
using System.Collections.Generic;


namespace Domain.Entities.Classification
{
	public class Category : Entity
	{
		public string Title { get; private set; }


		// Relationships
		public long? ParentCategoryID { get; private set; }

		// Navigations links
		public Category ParentCategory { get; private set; }
		public IList<Category> SubCategories { get; private set; }
		public IList<Book> Books { get; private set; }


		// Logic
		public Category(string title, long? parentCategoryID=null)
		{
			Title = title;

			ParentCategoryID = parentCategoryID;
		}
	}
}
