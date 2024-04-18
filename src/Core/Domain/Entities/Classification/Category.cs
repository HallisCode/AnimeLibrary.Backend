
﻿using Domain.Entities.Book_;

using System.Collections.Generic;


namespace Domain.Entities.Classification
{
    public class Category : Entity<ulong>
	{
		public string Title { get; private set; }


		// Relationships
		public ulong? ParentCategoryID { get; set; }

		// Navigations links
		public Category ParentCategory { get; set; }
    
		public IList<Category> SubCategories { get; set; }
    
		public IList<Book> Books { get; set; }


		// Logic
		public Category(string title, ulong? parentCategoryID=null)
		{
			Title = title;

			ParentCategoryID = parentCategoryID;
		}
	}
}
