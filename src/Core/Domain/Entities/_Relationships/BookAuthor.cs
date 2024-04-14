using Domain.Entities._Book;

namespace Domain.Entities._Relationships
{
    public class BookAuthor
    {
        #region Relationships
        public long BookID { get; set; }
        public Book Book { get; set; }

        public long AuthorID { get; set; }
        public Author Author { get; set; }
        #endregion
    }
}
