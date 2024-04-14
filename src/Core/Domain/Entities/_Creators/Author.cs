using Domain.Entities._Relationships;
using System;
using System.Collections.Generic;

namespace Domain.Entities._Creators
{
    public class Author : Entity
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public DateOnly DateBirth { get; set; }

        public DateOnly DateDeath { get; set; }

        public string Description { get; set; }

        #region Relationships
        public IList<BookAuthor> BookAuthors { get; set; }
        #endregion
    }
}
