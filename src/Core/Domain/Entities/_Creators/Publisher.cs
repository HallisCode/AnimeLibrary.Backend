using Domain.Entities._Book;
using System.Collections.Generic;

namespace Domain.Entities._Creators
{
	public class Publisher : Entity
	{
		public string Title { get; set; }


		// Navigations links
		public IList<Book> Books { get; set; }
	}
}
