using Domain.Entities._Book;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.IRepositories._Book
{
	public interface IBookRepository
	{
		Task<Book> GetAsync(long ID);

		Task<IList<Book>> GetByMatchAsync(string title);

		Task<Book> Create(Book book);

		Task Update(Book book);

		Task Delete(Book book);
	}
}
