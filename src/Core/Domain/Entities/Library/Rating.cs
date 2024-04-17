namespace Domain.Entities.Library
{
	public class Rating : Entity<ulong>
	{
		public double Score { get; private set; }


		// Relationships
		public ulong UserID { get; private set; }
		public ulong BookID { get; private set; }


		// Logic
		public Rating(double score, ulong userID, ulong bookID)
		{
			Score = score;

			UserID = userID;

			BookID = bookID;
		}
	}
}
