namespace Domain.Entities.Auth
{

	public class Security : Entity<ulong>
	{
		public string Email { get; private set; }

		public string Password { get; private set; }


		// Relationships
		public ulong UserID { get; private set; }


		// Logic
		public Security(string email, string password, ulong userID)
		{
			Email = email;

			Password = password;

			UserID = userID;
		}

		public void Update(string email = null, string password = null)
		{
			if (email is not null) Email = email;

			if (password is not null) Password = password;
		}
	}
}
