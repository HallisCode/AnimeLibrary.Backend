using Domain.IEntites.Book_;

namespace Application.DTO.Book_
{
	public record CreateBookRequest : IBook
	{
		public string Title => throw new System.NotImplementedException();

		public string ISBN13 => throw new System.NotImplementedException();

		public int YearRelease => throw new System.NotImplementedException();

		public int CountPages => throw new System.NotImplementedException();

		public string Description => throw new System.NotImplementedException();

		// Дополнительные поля которые могут понадобиться
	}
}
