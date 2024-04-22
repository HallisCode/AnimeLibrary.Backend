using Domain.Entities.User_;
using Domain.Enums;
using Domain.Validation.Models;
using FluentValidation;

namespace Domain.Entities.Book_
{
	public class Review : Entity<ulong>
	{
		public string Content { get; private set; }

		public ReviewType Type { get; private set; }


		// Relationships
		public ulong UserID { get; private set; }
		public ulong BookID { get; private set; }

		// Navigations links
		public User User { get; private set; }
		public Book Book { get; private set; }


		// Logic
		public Review
			(
			string content,
			ulong userID,
			ulong bookID,
			ReviewType type = ReviewType.Neutral
			)
		{
			Content = content;

			Type = type;

			UserID = userID;

			BookID = bookID;
		}

		public void Update(string content = null, ReviewType? type = null)
		{
			if (content is not null) Content = content;

			if (type is not null) Type = (ReviewType)type;
		}
	}
}
