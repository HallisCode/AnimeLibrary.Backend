namespace Domain.Entities._Book
{
	public class Rating : Entity
	{
		public double Score { get; set; }


		// Relationships
		public long UserID { get; set; }
		public long BookID { get; set; }
	}
}
