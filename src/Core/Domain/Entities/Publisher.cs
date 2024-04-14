using Domain.Entities._Book;
using System.Collections.Generic;

namespace Domain.Entities
{
	public class Publisher : Entity
	{
		public string Title { get; set; }

		#region Relationships
		public IList<Book> Books { get; set; }
		#endregion
	}
}
