using Domain.Entities.Classification;
using Domain.Entities.Creators;
using Domain.Entities.Relationships;
using Domain.Validation.Models;
using FluentValidation;
using System.Collections.Generic;

namespace Domain.Entities.Book_
{
	public class Book : Entity<ulong>
	{
		public string Title { get; private set; }

		public string ISBN13 { get; private set; }

		public int? YearRelease { get; private set; }

		public int? CountPages { get; private set; }

		public string Description { get; private set; }


		// Relationships
		public ulong? PublisherID { get; private set; }

		// Navigations links
		public IList<BookAuthor> BookAuthors { get; private set; }

		public IList<Category> Categories { get; private set; }

		public Publisher Publisher { get; private set; }


		// Logic
		public Book(
			string title, string isbn13 = null,
			int? yearRelese = null, int? countPages = null,
			string description = null, ulong? publisherID = null,
			IList<Author> authors = null, IList<Category> categories = null
			)
		{
			Title = title;

			if (isbn13 is not null) ISBN13 = isbn13;

			if (yearRelese is not null) YearRelease = yearRelese;

			if (countPages is not null) CountPages = countPages;

			if (description is not null) Description = description;

			if (publisherID is not null) PublisherID = publisherID;

			if (categories is not null) Categories = categories;

			if (authors is not null) ChangeAuthors(authors);

			Validate();
		}

		public void Update(
			string title = null, string isbn13 = null,
			int? yearRelese = null, int? countPages = null,
			string description = null, ulong? publisherID = null,
			IList<Author> authors = null, IList<Category> categories = null
			)
		{
			if (title is not null) Title = title;

			if (isbn13 is not null) ISBN13 = isbn13;

			if (yearRelese is not null) YearRelease = yearRelese;

			if (countPages is not null) CountPages = countPages;

			if (description is not null) Description = description;

			if (publisherID is not null) PublisherID = publisherID;

			if (categories is not null) Categories = categories;

			if (authors is not null) ChangeAuthors(authors);

			Validate();
		}

		private void ChangeAuthors(IList<Author> authors)
		{
			BookAuthors = null;

			foreach (Author author in authors)
			{
				BookAuthors.Add(new BookAuthor(authorID: author.ID, bookID: this.ID));
			}
		}

		protected override void Validate()
		{
			IValidator<Book> validator = new BookValidator();

			validator.ValidateAndThrow(this);
		}
	}
}
