using Domain.Entities.Book_;
using System.Collections.Generic;

namespace Domain.Entities.Creators
{
	public class Publisher : Entity<ulong>
	{
		public string Name { get; set; }


		// Navigations links
		public IList<Book> Books { get; set; }


		// Logic
		public Publisher(string title)
		{
			Name = title;
		}
	}
}
