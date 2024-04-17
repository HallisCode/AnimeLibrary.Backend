using Domain.Entities.Aggregates;
using Domain.Entities.User;
using Domain.Enums;

namespace Domain.Entities.Library
{
    public class Review : Entity<ulong>
	{
		public string Content { get; private set; }

		public ReviewType Type { get; private set; }


		// Relationships
		public ulong UserID { get; private set; }
		public ulong BookID { get; private set; }

		// Navigations links
		public User.User User { get; private set; }
		public Book Book { get; private set; }


		// Logic
		public Review(string content, ulong userID, ulong bookID, ReviewType type = ReviewType.Neutral)
		{
			Content = content;

			Type = type;

			UserID = userID;

			BookID = bookID;
		}

	}
}
