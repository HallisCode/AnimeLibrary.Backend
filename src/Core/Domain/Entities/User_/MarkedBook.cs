using Domain.Entities.Book_;
using Domain.Enums;

namespace Domain.Entities.User_
{
    public class MarkedBook : Entity<ulong>
	{
		public MarkedBookStatus Status { get; set; }


		// Relationships
		public ulong UserID { get; set; }
		public ulong BookID { get; set; }

		// Navigations links
		public User User { get; set; }
		public Book Book { get; set; }


		// Logic
		public MarkedBook(MarkedBookStatus status, ulong userID, ulong bookID)
		{
			Status = status;

			UserID = userID;

			BookID = bookID;
		}
	}
}
