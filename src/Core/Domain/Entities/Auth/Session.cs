﻿using System;


namespace Domain.Entities.Auth
{
	/// <summary>
	/// Представляет собой сущность, которая описывает сессию пользователя через какое-либо приложение.
	/// </summary>
	public class Session : Entity<Guid>
	{
		public string AppName { get; private set; }

		public DateTime LastUpdate { get; private set; }


		// Relationships
		public ulong UserID { get; private set; }


		// Logic
		public Session(string appName, ulong userID)
		{
			AppName = appName;

			UserID = userID;

			LastUpdate = DateTime.UtcNow;

			Validate();
		}

		public void Appear()
		{
			LastUpdate = DateTime.UtcNow;
		}

		protected override void Validate() { }
	}
}
