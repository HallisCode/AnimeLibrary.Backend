namespace Domain.Entities.BookData
{
	public class Rating : Entity<ulong>
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
