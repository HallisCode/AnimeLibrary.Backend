using Database.IRepositories.Book_;
using Domain.Entities.Book_;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Postgresql.Repositories.Book_
{
	public class RatingRepository : IRatingRepository
	{
		private ApplicationDbContext dbContext;


		public RatingRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public async Task CreateAsync(Rating entity)
		{
			dbContext.Add(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteFirstAsync(Rating entity)
		{
			dbContext.Remove(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task<Rating> GetFirstByAsync(Expression<Func<Rating, bool>> predicate)
		{
			return await dbContext.Rating.FirstOrDefaultAsync(predicate);
		}

		public async Task UpdateAsync(Rating entity)
		{
			dbContext.Update(entity);

			await dbContext.SaveChangesAsync();
		}
	}
}
