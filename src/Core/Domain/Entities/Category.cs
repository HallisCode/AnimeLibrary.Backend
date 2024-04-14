using System.Collections.Generic;


namespace Domain.Entities
{
    public class Category : Entity
	{
		public string Title { get; set; }

		#region Relationships
		public Category ParentCategory { get; set; }
		public long? ParentCategoryID { get; set; }

		public IList<Category> SubCategories { get; set; }

		public IList<Book> Books { get; set; }
		#endregion
	}
}
