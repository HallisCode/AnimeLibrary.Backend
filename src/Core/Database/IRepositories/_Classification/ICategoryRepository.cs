using Domain.Entities._Classification;
using System.Threading.Tasks;

namespace Database.IRepositories._Classification
{
	public interface ICategoryRepository
	{
		Task<Category> GetByMatchAsync(string title);

		Task<Category> CreateAsync(Category category);

		Task UpdateAsync(Category category);
	}
}
