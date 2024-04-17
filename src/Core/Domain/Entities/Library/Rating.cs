namespace Domain.Entities.Library
{
	public class Rating : Entity
	{
		public double Score { get; private set; }


		// Relationships
		public long UserID { get; private set; }
		public long BookID { get; private set; }


		// Logic
		public Rating(double score, long userID, long bookID)
		{
			Score = score;

			UserID = userID;

			BookID = bookID;
		}
	}
}
