using Domain.Entities.User;
using Domain.Enums;

namespace Domain.Entities.Library
{
	public class Review : Entity
	{
		public string Content { get; private set; }

		public ReviewType Type { get; private set; }


		// Relationships
		public long UserID { get; private set; }
		public long BookID { get; private set; }

		// Navigations links
		public User.User User { get; private set; }
		public Book Book { get; private set; }


		// Logic
		public Review(string content, long userID, long bookID, ReviewType type = ReviewType.Neutral)
		{
			Content = content;

			Type = type;

			UserID = userID;

			BookID = bookID;
		}

	}
}
