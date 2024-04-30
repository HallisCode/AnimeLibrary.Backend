using Database.IRepositories.User_;
using Domain.Entities.User_;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Postgresql.Repositories.User_
{
	public class MarkedBookRepository : IMarkedBookRepository
	{
		private ApplicationDbContext dbContext;


		public MarkedBookRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public async Task CreateAsync(MarkedBook entity)
		{
			dbContext.Add(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteFirstAsync(MarkedBook entity)
		{
			dbContext.Remove(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task<List<MarkedBook>> GetAllByAsync(
			Expression<Func<MarkedBook, bool>> predicate,
			int take, int offset,
			Expression<Func<MarkedBook, object>> orderBy = null,
			params Expression<Func<MarkedBook, object>>[] thenBy
		)
		{
			IQueryable<MarkedBook> query = dbContext.MarkedBook.Where(predicate).Skip(offset).Take(take);

			if (orderBy is not null)
			{
				IOrderedQueryable<MarkedBook> orderedQuery = query.OrderBy(orderBy);

				foreach (Expression<Func<MarkedBook, object>> addOrderBy in thenBy)
				{
					orderedQuery.ThenBy(addOrderBy);
				}

				return await orderedQuery.ToListAsync();
			}

			return await query.ToListAsync();
		}

		public async Task<List<MarkedBook>> GetAllByAsync(Expression<Func<MarkedBook, bool>> predicate, int take, int offset)
		{
			return await dbContext.MarkedBook.Where(predicate).Skip(offset).Take(take).ToListAsync();
		}

		public async Task UpdateAsync(MarkedBook entity)
		{
			dbContext.Update(entity);


			await dbContext.SaveChangesAsync();
		}
	}
}
