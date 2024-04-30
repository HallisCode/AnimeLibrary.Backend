using Database.IRepositories.Creators;
using Domain.Entities.Classification;
using Domain.Entities.Creators;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Postgresql.Repositories.Creators
{
	public class PublisherRepository : IPublisherRepository
	{
		private ApplicationDbContext dbContext;


		public PublisherRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public async Task CreateAsync(Publisher entity)
		{
			dbContext.Add(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteFirstAsync(Publisher entity)
		{
			dbContext.Remove(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task<List<Publisher>> GetAllByLikeAsync(
			string matchingField, string pattern,
			int take, int offset,
			Expression<Func<Publisher, object>> orderBy,
			params Expression<Func<Publisher, object>>[] thenBy
		)
		{
			IQueryable<Publisher> query = dbContext.Publisher.Where(book => EF.Functions.ILike(matchingField, pattern)).Skip(offset).Take(take);

			if (orderBy is not null)
			{
				IOrderedQueryable<Publisher> orderedQuery = query.OrderBy(orderBy);

				foreach (Expression<Func<Publisher, object>> addOrderBy in thenBy)
				{
					orderedQuery.ThenBy(addOrderBy);
				}

				return await orderedQuery.ToListAsync();
			}

			return await query.ToListAsync();
		}

		public async Task<List<Publisher>> GetAllByLikeAsync(string matchingField, string pattern, int take, int offset)
		{
			return await dbContext.Publisher.Where(book => EF.Functions.ILike(matchingField, pattern)).Skip(offset).Take(take).ToListAsync();
		}

		public async Task<Publisher> GetFirstByAsync(Expression<Func<Publisher, bool>> predicate)
		{
			return await dbContext.Publisher.FirstOrDefaultAsync(predicate);
		}

		public async Task UpdateAsync(Publisher entity)
		{
			dbContext.Update(entity);


			await dbContext.SaveChangesAsync();
		}
	}
}
