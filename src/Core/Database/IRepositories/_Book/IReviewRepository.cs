using Domain.Entities._Book;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Database.IRepositories._Book
{
	public interface IReviewRepository
	{
		Task<IList<Review>> GetByBookAsync(long ID, int offset);

		Task<Review> CreateAsync(Review review);

		Task UpdateAsync(long ID);

		Task DeleteAsync(long ID);
	}
}
