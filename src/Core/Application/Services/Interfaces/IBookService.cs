using Application.DTO.ReturningType;
using Domain.Entities.Book_;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
	public interface IBookService
	{
		Task<IOperationResult<Book>> GetBookByAsync(ulong ID);

		Task<IOperationResult<List<Book>>> GetBooksByAsync();

		Task<IOperationResult<Review>> AddReviewAsync();

		Task<IOperationResult> AddRatingAsync();
	}
}
