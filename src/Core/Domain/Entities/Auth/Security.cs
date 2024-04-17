namespace Domain.Entities.Auth
{
	public class Security : Entity
	{
		public string Email { get; private set; }

		public string Password { get; private set; }


		// Relationships
		public long UserID { get; private set; }


		// Logic
		public Security(string email, string password)
		{
			Email = email;

			Password = password;
		}
	}
}
