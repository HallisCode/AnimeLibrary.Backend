using Domain.Entities._Book;
using System.Threading.Tasks;

namespace Database.IRepositories._Book
{
	public interface IRatingRepository
	{
		Task<Rating> GetByUserAsync(long ID);

		Task<Rating> CreateAsync(Rating rating);

		Task UpdateAsync(long ID);

		Task DeleteAsync(long ID);
	}
}
