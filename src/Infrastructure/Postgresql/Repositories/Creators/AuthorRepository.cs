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
	public class AuthorRepository : IAuthorRepository
	{
		private ApplicationDbContext dbContext;


		public AuthorRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public async Task CreateAsync(Author entity)
		{
			dbContext.Add(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteFirstAsync(Author entity)
		{
			dbContext.Remove(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task<List<Author>> GetAllByLikeAsync(
			string matchingField, string pattern,
			int take, int offset,
			Expression<Func<Author, object>> orderBy,
			params Expression<Func<Author, object>>[] thenBy
		)
		{
			IQueryable<Author> query = dbContext.Author.Where(book => EF.Functions.ILike(matchingField, pattern)).Skip(offset).Take(take);

			if (orderBy is not null)
			{
				IOrderedQueryable<Author> orderedQuery = query.OrderBy(orderBy);

				foreach (Expression<Func<Author, object>> addOrderBy in thenBy)
				{
					orderedQuery.ThenBy(addOrderBy);
				}

				return await orderedQuery.ToListAsync();
			}

			return await query.ToListAsync();
		}

		public async Task<List<Author>> GetAllByLikeAsync(string matchingField, string pattern, int take, int offset)
		{
			return await dbContext.Author.Where(book => EF.Functions.ILike(matchingField, pattern)).Skip(offset).Take(take).ToListAsync();
		}

		public async Task<Author> GetFirstByAsync(Expression<Func<Author, bool>> predicate)
		{
			return await dbContext.Author.FirstOrDefaultAsync(predicate);
		}

		public async Task UpdateAsync(Author entity)
		{
			dbContext.Update(entity);


			await dbContext.SaveChangesAsync();
		}
	}
}
