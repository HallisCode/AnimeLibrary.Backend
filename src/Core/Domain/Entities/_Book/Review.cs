using Domain.Entities._User;
using Domain.Enums;

namespace Domain.Entities._Book
{
    public class Review : Entity
	{
		public string Content { get; set; }

		public ReviewType Type { get; set; }

		#region Relationships
		public User User { get; set; }
		public long UserID { get; set; }

		public Book Book { get; set; }
		public long BookID { get; set; }
		#endregion
	}
}
