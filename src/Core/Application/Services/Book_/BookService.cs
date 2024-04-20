using Application.DTO.Book_;
using Application.IServices.Book_;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Book_
{
	internal class BookService : IBookService
	{
		public Task<BookResponse> CreateBookAsync(CreateBookRequest createBookDTO)
		{
			throw new NotImplementedException();
		}

		public Task DeleteBookAsync(ulong bookID)
		{
			throw new NotImplementedException();
		}

		public Task<List<BookResponse>> FindBooksAsync(FindBooksRequest findBooksDTO)
		{
			throw new NotImplementedException();
		}

		public Task<BookResponse> GetBookAsync(ulong ID)
		{
			throw new NotImplementedException();
		}

		public Task UpdateBookAsync(UpdateBookRequest updateBookDTO)
		{
			throw new NotImplementedException();
		}
	}
}
