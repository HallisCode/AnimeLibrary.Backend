using Domain.Entities.Classification;
using Domain.Entities.Creators;
using Domain.Entities.Relationships;
using Domain.IEntites.Book_;
using System.Collections.Generic;

namespace Domain.Entities.Book_
{
	public class Book : Entity<ulong>, IBook
	{
		public string Title { get; set; }

		public string ISBN13 { get; set; }

		public int YearRelease { get; set; }

		public int CountPages { get; set; }

		public string Description { get; set; }


		// Relationships
		public ulong PublisherID { get; set; }

		// Navigations links
		public IList<BookAuthor> BookAuthors { get; set; }

		public IList<Category> Categories { get; set; }

		public Publisher Publisher { get; set; }


		// Logic
		public Book(string title, string isbn13, int yearRelese, int countPages, string description, ulong publisherID)
		{
			Title = title;

			ISBN13 = isbn13;

			YearRelease = yearRelese;

			CountPages = countPages;

			Description = description;

			PublisherID = publisherID;
		}
	}
}
