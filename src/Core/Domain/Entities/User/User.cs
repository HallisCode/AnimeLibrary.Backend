namespace Domain.Entities.User
{
	public class User : Entity<ulong>
	{
		public string Username { get; private set; }


		// Logic
		public User(string username)
		{
			Username = username;
		}

	}
}
