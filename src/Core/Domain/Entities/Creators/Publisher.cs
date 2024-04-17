using Domain.Entities.BookData;
using System.Collections.Generic;

namespace Domain.Entities.Creators
{
    public class Publisher : Entity<ulong>
	{
		public string Title { get; set; }


		// Navigations links
		public IList<BookData.Book> Books { get; set; }


		// Logic
		public Publisher(string title)
		{
			Title = title;
		}
	}
}
