using Domain.Entities.Book_;
using Domain.Entities.Creators;

namespace Domain.Entities.Relationships
{
	public class BookAuthor
	{
		// Relationships
		public ulong AuthorID { get; set; }
		public ulong BookID { get; set; }

		// Navigations links
		public Author Author { get; set; }
		public Book Book { get; set; }


		// Logic
		public BookAuthor(ulong authorID, ulong bookID)
		{
			AuthorID = authorID;

			BookID = bookID;
		}
	}
}
