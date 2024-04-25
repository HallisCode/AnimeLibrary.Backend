using Database.IRepositories.Book_;
using Domain.Entities.Book_;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Postgresql.Repositories.Book_
{
	public class ReviewRepository : IReviewRepository
	{
		private ApplicationDbContext dbContext;


		public ReviewRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public async Task CreateAsync(Review entity)
		{
			dbContext.Add(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteFirstAsync(Review entity)
		{
			dbContext.Remove(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task<Review> GetFirstByAsync(Expression<Func<Review, bool>> predicate)
		{
			return await dbContext.Review.FirstOrDefaultAsync(predicate);
		}

		public async Task UpdateAsync(Review entity)
		{
			dbContext.Update(entity);


			await dbContext.SaveChangesAsync();
		}
	}
}
