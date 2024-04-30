using Domain.Entities.Book_;
using System.Collections.Generic;

namespace Domain.Entities.Creators
{
	public class Publisher : Entity<ulong>
	{
		public string Name { get; private set; }


		// Navigations links
		public IList<Book> Books { get; private set; }


		// Logic
		public Publisher(string name)
		{
			Name = name;
		}

		public void Update(string name)
		{
			Name = name;
		}
	}
}
