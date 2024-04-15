
using Domain.Entities._Book;
using Domain.Enums;

namespace Domain.Entities._User
{
	public class MarkedBook : Entity
	{
		public MarkedBookStatus Status { get; set; }


		// Relationships
		public long UserID { get; set; }
		public long BookID { get; set; }

		// Navigations links
		public User User { get; set; }
		public Book Book { get; set; }
	}
}
