using Application.DTO.Requests.Book_;
using Application.DTO.Responses.Book_;
using Application.IServices.Book_;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Book_
{
	internal class BookService : IBookService
	{
		public Task<BookDTO> CreateBookAsync(CreateBookDTO createBookDTO)
		{
			throw new NotImplementedException();
		}

		public Task DeleteBookAsync(ulong bookID)
		{
			throw new NotImplementedException();
		}

		public Task<List<BookDTO>> FindBooksAsync(FindBooksDTO findBooksDTO)
		{
			throw new NotImplementedException();
		}

		public Task<BookDTO> GetBookAsync(ulong ID)
		{
			throw new NotImplementedException();
		}

		public Task UpdateBookAsync(UpdateBookDTO updateBookDTO)
		{
			throw new NotImplementedException();
		}
	}
}
