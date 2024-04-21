using Domain.IEntites.Book_;

namespace Domain.Entities.Book_
{
	public class Rating : Entity<ulong>, IRating
	{
		public double Score { get; set; }


		// Relationships
		public ulong UserID { get; set; }
		public ulong BookID { get; set; }


		// Logic
		public Rating(double score, ulong userID, ulong bookID)
		{
			Score = score;

			UserID = userID;

			BookID = bookID;
		}
	}
}
