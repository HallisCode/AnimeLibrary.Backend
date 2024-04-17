using Domain.Entities.Library;
using System.Collections.Generic;

namespace Domain.Entities.Creators
{
	public class Publisher : Entity<ulong>
	{
		public string Title { get; private set; }


		// Navigations links
		public IList<Book> Books { get; private set; }


		// Logic
		public Publisher(string title)
		{
			Title = title;
		}
	}
}
