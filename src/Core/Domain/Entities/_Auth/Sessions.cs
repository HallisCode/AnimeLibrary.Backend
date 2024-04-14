using System;


namespace Domain.Entities._Auth
{
	public class Sessions
	{
		public Guid ID { get; set; }

		public DateTime LastUpdate { get; set; }
	}
}
