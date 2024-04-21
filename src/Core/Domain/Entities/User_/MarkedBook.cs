using Domain.Entities.Book_;
using Domain.Enums;

namespace Domain.Entities.User_
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

		public void Update(MarkedBookStatus status)
		{
			Status = status;
		}

		protected override void Validate()
		{
			throw new System.NotImplementedException();
		}
	}
}
