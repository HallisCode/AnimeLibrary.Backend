using Domain.Entities.User;
using Domain.Enums;

namespace Domain.Entities.Library
{
	public class Review : Entity
	{
		public string Content { get; set; }

		public ReviewType Type { get; set; }


		// Relationships
		public long UserID { get; set; }
		public long BookID { get; set; }

		// Navigations links
		public User.User User { get; set; }
		public Book Book { get; set; }

	}
}
