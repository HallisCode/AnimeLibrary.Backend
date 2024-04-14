using System;


namespace Domain.Entities._Auth
{
	public class Session
	{
		public Guid ID { get; set; }

		public string AppName { get; set; }

		public DateTime LastUpdate { get; set; }
	}
}
