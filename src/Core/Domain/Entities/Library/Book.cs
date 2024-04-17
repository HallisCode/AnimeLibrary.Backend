using Domain.Entities.Classification;
using Domain.Entities.Creators;
using Domain.Entities.Relationships;
using System.Collections.Generic;

namespace Domain.Entities.Library
{
    public class Book : Entity<ulong>
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
    }
}
