using Database.IRepositories.Book_;
using Domain.Entities.Auth;
using Domain.Entities.Book_;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Postgresql.Repositories.Book_
{
	public class BookRepository : IBookRepository
	{
		private ApplicationDbContext dbContext;


		public BookRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public async Task CreateAsync(Book entity)
		{
			dbContext.Add(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteFirstAsync(Book entity)
		{
			dbContext.Remove(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task<List<Book>> GetAllByLikeAsync(
			string matchingField, string pattern,
			int take, int offset,
			Expression<Func<Book, object>> orderBy = null,
			params Expression<Func<Book, object>>[] thenBy)
		{
			IQueryable<Book> query = dbContext.Book.Where(book => EF.Functions.ILike(matchingField, pattern)).Skip(offset).Take(take);

			if (orderBy is not null)
			{
				IOrderedQueryable<Book> orderedQuery = query.OrderBy(orderBy);

				foreach (Expression<Func<Book, object>> addOrderBy in thenBy)
				{
					orderedQuery.ThenBy(addOrderBy);
				}

				return await orderedQuery.ToListAsync();
			}

			return await query.ToListAsync();
		}

		public async Task<List<Book>> GetAllByLikeAsync(string matchingField, string pattern, int take, int offset)
		{
			return await dbContext.Book.Where(book => EF.Functions.ILike(matchingField, pattern)).Skip(offset).Take(take).ToListAsync();
		}

		public async Task<Book> GetFirstByAsync(Expression<Func<Book, bool>> predicate)
		{
			return await dbContext.Book.FirstOrDefaultAsync(predicate);
		}

		public async Task UpdateAsync(Book entity)
		{
			dbContext.Update(entity);


			await dbContext.SaveChangesAsync();
		}
	}
}
