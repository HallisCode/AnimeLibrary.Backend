using Domain.Entities.Classification;
using Domain.Entities.Creators;
using Domain.Entities.Relationships;
using Domain.Exceptions;
using System.Collections.Generic;

namespace Domain.Entities.Aggregates
{
	public class Book : Entity<ulong>, IAggregateRoot
	{
		public string Title { get; private set; }

		public string ISBN13 { get; private set; }

		public int YearRelease { get; private set; }

		public int CountPages { get; private set; }

		public string Description { get; private set; }


		// Relationships
		public ulong PublisherID { get; private set; }

		// Navigations links
		public IList<BookAuthor> BookAuthors { get; private set; }

		public IList<Category> Categories { get; private set; }

		public Publisher Publisher { get; private set; }


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

		public void ChangeTitle(string title)
		{
			Title = title;
		}

		public void ChangeISBN13(string isbn13)
		{
			ISBN13 = isbn13;
		}

		public void ChangeYearRelease(int yearRelese)
		{
			YearRelease = yearRelese;
		}

		public void ChangeCountPages(int countPages)
		{
			CountPages = countPages;
		}

		public void ChangeDescription(string description)
		{
			Description = description;
		}

		public void ChangePublisherId(ulong publisherID)
		{
			PublisherID = publisherID;
		}

		public void AddAuthors(IEnumerable<Author> authors)
		{
			VerifyAvailableAuthors();

			foreach (Author author in authors)
			{
				BookAuthors.Add(new BookAuthor(author.ID, this.ID));
			}
		}

		public void AddCategories(IEnumerable<Category> categories)
		{
			VerifyAvailableCategories();

			foreach (Category category in categories)
			{
				Categories.Add(category);
			}
		}

		private void VerifyAvailableAuthors()
		{
			if (BookAuthors == null) throw new InvalidAggregate($"Отсутствуют {nameof(BookAuthors)}.");
		}

		private void VerifyAvailableCategories()
		{
			if (Categories == null) throw new InvalidAggregate($"Отсутствуют {nameof(Categories)}.");
		}
	}
}
