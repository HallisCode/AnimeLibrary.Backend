namespace Domain.Entities._Book
{
	public class Rating : Entity
	{
		public double Score { get; set; }

		#region Relationships
		public long UserID { get; set; }

		public long BookID { get; set; }
		#endregion
	}
}
