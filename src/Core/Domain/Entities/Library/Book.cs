using Domain.Entities.Classification;
using Domain.Entities.Creators;
using Domain.Entities.Relationships;
using System.Collections.Generic;

namespace Domain.Entities.Library
{
	public class Book : Entity
	{
		public string Title { get; set; }

		public string ISBN13 { get; set; }

		public int YearRelease { get; set; }

		public int CountPages { get; set; }

		public string Description { get; set; }


		// Relationships
		public long PublisherID { get; set; }

		// Navigations links
		public IList<BookAuthor> BookAuthors { get; set; }

		public IList<Category> Categories { get; set; }

		public Publisher Publisher { get; set; }
	}
}
