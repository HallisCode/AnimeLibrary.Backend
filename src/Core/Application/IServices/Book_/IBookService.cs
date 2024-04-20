using Application.DTO.Requests.Book_;
using Application.DTO.Responses.Book_;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.IServices.Book_
{
	public interface IBookService
	{
		Task<List<BookDTO>> FindBooksAsync(FindBooksDTO findBooksDTO);

		Task<BookDTO> GetBookAsync(ulong ID);

		Task<BookDTO> CreateBookAsync(CreateBookDTO createBookDTO);

		Task UpdateBookAsync(UpdateBookDTO updateBookDTO);

		Task DeleteBookAsync(ulong bookID);

	}
}
