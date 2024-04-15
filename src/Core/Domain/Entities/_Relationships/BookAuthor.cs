using Domain.Entities._Book;
using Domain.Entities._Creators;

namespace Domain.Entities._Relationships
{
	public class BookAuthor
	{
		// Relationships
		public long AuthorID { get; set; }
		public long BookID { get; set; }

		// Navigations links
		public Author Author { get; set; }
		public Book Book { get; set; }
	}
}
