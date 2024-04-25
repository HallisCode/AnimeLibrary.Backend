using Database.IRepositories.Auth;
using Domain.Entities.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace Postgresql.Repositories.Auth
{
	public class SecurityRepository : ISecurityRepository
	{
		private ApplicationDbContext dbContext;

		public SecurityRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task CreateAsync(Security entity)
		{
			dbContext.Security.Add(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteFirstByAsync(Security entity)
		{
			dbContext.Remove(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task<Security> GetFirstByAsync(Expression<Func<Security, bool>> predicate)
		{
			return await dbContext.Security.FirstOrDefaultAsync(predicate);
		}

		public async Task UpdateAsync(Security entity)
		{
			dbContext.Security.Update(entity);


			await dbContext.SaveChangesAsync();
		}
	}
}
