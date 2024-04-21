namespace Domain.IEntites.Book_
{
	public interface IBook
	{
		public string Title { get; }

		public string ISBN13 { get; }

		public int YearRelease { get; }

		public int CountPages { get; }

		public string Description { get; }
	}
}
