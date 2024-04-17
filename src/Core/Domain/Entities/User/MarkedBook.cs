
using Domain.Entities.Library;
using Domain.Enums;

namespace Domain.Entities.User
{
	public class MarkedBook : Entity
	{
		public MarkedBookStatus Status { get; private set; }


		// Relationships
		public long UserID { get; private set; }
		public long BookID { get; private set; }

		// Navigations links
		public User User { get; private set; }
		public Book Book { get; private set; }


		// Logic
		public MarkedBook(MarkedBookStatus status, long userID, long bookID)
		{
			Status = status;

			UserID = userID;

			BookID = bookID;
		}
	}
}
