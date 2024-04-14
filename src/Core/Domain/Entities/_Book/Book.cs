using Domain.Entities._Classification;
using Domain.Entities._Creators;
using Domain.Entities._Relationships;
using System.Collections.Generic;

namespace Domain.Entities._Book
{
    public class Book : Entity
	{
		public string Title { get; set; }

		public string ISBN13 { get; set; }

		public int YearRelease { get; set; }

		public int CountPages { get; set; }

		public string Description { get; set; }

		#region Relationships
		public IList<BookAuthor> BookAuthors { get; set; }

		public IList<Category> Categories { get; set; }

		public Publisher Publisher { get; set; }
		public long PublisherID { get; set; }
		#endregion
	}
}
