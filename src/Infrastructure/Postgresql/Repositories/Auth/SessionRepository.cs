using Database.IRepositories.Auth;
using Domain.Entities.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Postgresql.Repositories.Auth
{
	public class SessionRepository : ISessionRepository
	{
		private ApplicationDbContext dbContext;


		public SessionRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public async Task CreateAsync(Session entity)
		{
			dbContext.Add(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteAllAsync(IEnumerable<Session> entities)
		{
			dbContext.RemoveRange(entities);


			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteFirstAsync(Session entity)
		{
			dbContext.Remove(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task<List<Session>> GetAllByAsync(
			Expression<Func<Session, bool>> predicate,
			int take, int offset,
			Expression<Func<Session, object>> orderBy = null,
			params Expression<Func<Session, object>>[] thenBy
		)
		{
			IQueryable<Session> query = dbContext.Session.Where(predicate).Skip(offset).Take(take);

			if (orderBy is not null)
			{
				IOrderedQueryable<Session> orderedQuery = query.OrderBy(orderBy);

				foreach (Expression<Func<Session, object>> addOrderBy in thenBy)
				{
					orderedQuery.ThenBy(addOrderBy);
				}

				return await orderedQuery.ToListAsync();
			}

			return await query.ToListAsync();
		}

		public async Task<List<Session>> GetAllByAsync(Expression<Func<Session, bool>> predicate, int take, int offset)
		{
			return await dbContext.Session.Where(predicate).Skip(offset).Take(take).ToListAsync();
		}

		public async Task<Session> GetFirstByAsync(Expression<Func<Session, bool>> predicate)
		{
			return await dbContext.Session.FirstOrDefaultAsync(predicate);
		}

		public async Task UpdateAsync(Session entity)
		{
			dbContext.Update(entity);


			await dbContext.SaveChangesAsync();
		}
	}
}
