using System;

namespace Domain.IEntites.Creators
{
	public interface IAuthor
	{
		public string Name { get; }

		public string LastName { get; }

		public DateOnly DateBirth { get; }

		public DateOnly DateDeath { get; }

		public string Description { get; }
	}
}
