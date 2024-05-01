namespace Domain.Entities.Book_
{
	public class Rating : IComposePK
	{
		public ValueObjects.DecimalRating Score { get; private set; }


		// Relationships
		public ulong UserID { get; set; }
		public ulong BookID { get; set; }


		// Logic
		private Rating() { }

		public Rating(ValueObjects.DecimalRating score, ulong userID, ulong bookID)
		{
			Score = score;

			UserID = userID;

			BookID = bookID;
		}

		public void Update(ValueObjects.DecimalRating rating)
		{
			Score = rating;

		}
	}
}
