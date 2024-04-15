using Domain.Entities.Library;
using System.Collections.Generic;


namespace Domain.Entities.Classification
{
	public class Category : Entity
	{
		public string Title { get; set; }


		// Relationships
		public long? ParentCategoryID { get; set; }

		// Navigations links
		public Category ParentCategory { get; set; }
		public IList<Category> SubCategories { get; set; }
		public IList<Book> Books { get; set; }
	}
}
