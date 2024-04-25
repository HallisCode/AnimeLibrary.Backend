using Database.IRepositories.Classification;
using Domain.Entities.Classification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Postgresql.Repositories.Book_
{
	public class CategoryRepository : ICategoryRepository
	{
		private ApplicationDbContext dbContext;


		public CategoryRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public async Task CreateAsync(Category entity)
		{
			dbContext.Add(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteFirstAsync(Category entity)
		{
			dbContext.Remove(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task<List<Category>> GetAllByLikeAsync(
			string matchingField, string pattern,
			int take, int offset,
			Expression<Func<Category, object>> orderBy,
			params Expression<Func<Category, object>>[] thenBy
		)
		{
			IQueryable<Category> query = dbContext.Category.Where(book => EF.Functions.ILike(matchingField, pattern)).Skip(offset).Take(take);

			if (orderBy is not null)
			{
				IOrderedQueryable<Category> orderedQuery = query.OrderBy(orderBy);

				foreach (Expression<Func<Category, object>> addOrderBy in thenBy)
				{
					orderedQuery.ThenBy(addOrderBy);
				}

				return await orderedQuery.ToListAsync();
			}

			return await query.ToListAsync();
		}

		public async Task<List<Category>> GetAllByLikeAsync(string matchingField, string pattern, int take, int offset)
		{
			return await dbContext.Category.Where(book => EF.Functions.ILike(matchingField, pattern)).Skip(offset).Take(take).ToListAsync();
		}

		public async Task<Category> GetFirstByAsync(Expression<Func<Category, bool>> predicate)
		{
			return await dbContext.Category.FirstOrDefaultAsync(predicate);
		}

		public async Task UpdateAsync(Category entity)
		{
			dbContext.Update(entity);


			await dbContext.SaveChangesAsync();
		}
	}
}
