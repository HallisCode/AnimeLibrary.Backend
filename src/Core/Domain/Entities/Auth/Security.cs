namespace Domain.Entities.Auth
{

	public class Security : Entity<ulong>
	{
		public string Email { get; set; }

		public string Password { get; set; }


		// Relationships
		public long UserID { get; set; }


		// Logic
		public Security(string email, string password)
		{
			Email = email;

			Password = password;
		}
	}
}
