﻿using Domain.Entities.Book;
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
		public IList<Book.Book> Books { get; set; }


		// Logic
		public Category(string title, ulong? parentCategoryID=null)
		{
			Title = title;

			ParentCategoryID = parentCategoryID;
		}
	}
}
