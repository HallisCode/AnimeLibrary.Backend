using Domain.Entities.User_;
using Domain.Enums;
using Domain.IEntites.Book_;

namespace Domain.Entities.Book_
{
	public class Review : Entity<ulong>, IReview
	{
		public string Content { get; set; }

		public ReviewType Type { get; set; }


		// Relationships
		public ulong UserID { get; set; }
		public ulong BookID { get; set; }

		// Navigations links
		public User User { get; set; }
		public Book Book { get; set; }


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
