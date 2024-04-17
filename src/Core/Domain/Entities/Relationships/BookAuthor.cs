using Domain.Entities.Library;
using Domain.Entities.Creators;

namespace Domain.Entities.Relationships
{
	public class BookAuthor
	{
		// Relationships
		public long AuthorID { get; private set; }
		public long BookID { get; private set; }

		// Navigations links
		public Author Author { get; private set; }
		public Book Book { get; private set; }


		// Logic
		public BookAuthor(long authorID, long bookID)
		{
			AuthorID = authorID;

			bookID = bookID;
		}
	}
}
