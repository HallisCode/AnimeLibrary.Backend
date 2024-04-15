using Domain.Entities.Library;
using System.Collections.Generic;

namespace Domain.Entities.Creators
{
	public class Publisher : Entity
	{
		public string Title { get; set; }


		// Navigations links
		public IList<Book> Books { get; set; }
	}
}
