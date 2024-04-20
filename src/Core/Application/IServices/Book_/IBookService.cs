using Application.DTO.Book_;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.IServices.Book_
{
	public interface IBookService
	{
		Task<List<BookResponse>> FindBooksAsync(FindBooksRequest request);

		Task<BookResponse> GetBookAsync(ulong ID);

		Task<BookResponse> CreateBookAsync(ulong userID, CreateBookRequest request);

		Task UpdateBookAsync(ulong userID, UpdateBookRequest request);

		Task DeleteBookAsync(ulong userID, DeleteBookRequest request);
	}
}
