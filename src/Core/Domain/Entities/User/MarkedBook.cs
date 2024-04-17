
using Domain.Entities.Library;
using Domain.Enums;

namespace Domain.Entities.User
{
	public class MarkedBook : Entity<ulong>
	{
		public MarkedBookStatus Status { get; private set; }


		// Relationships
		public ulong UserID { get; private set; }
		public ulong BookID { get; private set; }

		// Navigations links
		public User User { get; private set; }
		public Book Book { get; private set; }


		// Logic
		public MarkedBook(MarkedBookStatus status, ulong userID, ulong bookID)
		{
			Status = status;

			UserID = userID;

			BookID = bookID;
		}
	}
}
