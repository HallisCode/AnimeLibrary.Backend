using Domain.Entities.Library;
using Domain.Entities.Creators;

namespace Domain.Entities.Relationships
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
