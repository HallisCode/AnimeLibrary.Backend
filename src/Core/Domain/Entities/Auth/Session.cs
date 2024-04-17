using System;


namespace Domain.Entities.Auth
{
	public class Session
	{
		public Guid ID { get; private set; }

		public string AppName { get; private set; }

		public DateTime LastUpdate { get; private set; }


		// Relationships
		public long UserID { get; private set; }


		// Logic
		public Session(string appName, long userID)
		{
			AppName = appName;

			UserID = userID;

			LastUpdate = DateTime.UtcNow;
		}

		public void Appear()
		{
			LastUpdate = DateTime.UtcNow;
		}
	}
}
