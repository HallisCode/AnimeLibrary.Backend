namespace Domain.Entities.Library
{
	public class Rating : Entity
	{
		public double Score { get; set; }


		// Relationships
		public long UserID { get; set; }
		public long BookID { get; set; }
	}
}
