namespace Domain.Entities.UserData
{
	public class User : Entity<ulong>
	{
		public string Username { get; set; }


		// Logic
		public User(string username)
		{
			Username = username;
		}

	}
}
