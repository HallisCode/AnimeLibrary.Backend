using Application.DTO.Book_;
using Application.IServices.Book_;
using Database.IRepositories.Book_;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Book_
{
	public class BookService : IBookService
	{

		public Task<BookResponse> CreateBookAsync(ulong userID, CreateBookRequest request)
		{
			throw new NotImplementedException();
		}

		public Task DeleteBookAsync(ulong userID, DeleteBookRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<List<BookResponse>> FindBooksAsync(FindBooksRequest request)
		{
			throw new NotImplementedException();
		}

		public Task<BookResponse> GetBookAsync(ulong ID)
		{
			throw new NotImplementedException();
		}

		public Task UpdateBookAsync(ulong userID, UpdateBookRequest request)
		{
			throw new NotImplementedException();
		}
	}
}
