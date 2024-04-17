using Domain.Entities.Relationships;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Creators
{
	public class Author : Entity
	{
		public string Name { get; private set; }

		public string LastName { get; private set; }

		public DateOnly DateBirth { get; private set; }

		public DateOnly DateDeath { get; private set; }

		public string Description { get; private set; }


		// Navigations links
		public IList<BookAuthor> BookAuthors { get; private set; }


		// Logic
		public Author(string name, string lastName, DateOnly dateBirth, DateOnly dateDeath, string description)
		{
			Name = name;

			LastName = lastName;

			DateBirth = dateBirth;

			DateDeath = dateDeath;

			Description = description;
		}
	}
}
