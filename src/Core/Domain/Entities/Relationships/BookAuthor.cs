using Domain.Entities.Library;
using Domain.Entities.Creators;

namespace Domain.Entities.Relationships
{
	public class BookAuthor
	{
		// Relationships
		public ulong AuthorID { get; private set; }
		public ulong BookID { get; private set; }

		// Navigations links
		public Author Author { get; private set; }
		public Book Book { get; private set; }


		// Logic
		public BookAuthor(ulong authorID, ulong bookID)
		{
			AuthorID = authorID;

			bookID = bookID;
		}
	}
}
