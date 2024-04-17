using Domain.Entities.Book;
using System.Collections.Generic;

namespace Domain.Entities.Creators
{
    public class Publisher : Entity<ulong>
	{
		public string Title { get; set; }


		// Navigations links
		public IList<Book.Book> Books { get; set; }


		// Logic
		public Publisher(string title)
		{
			Title = title;
		}
	}
}
