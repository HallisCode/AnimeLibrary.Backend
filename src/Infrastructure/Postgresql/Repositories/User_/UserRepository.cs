using Database.IRepositories.User_;
using Domain.Entities.User_;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Postgresql.Repositories.User_
{
	public class UserRepository : IUserRepository
	{
		private ApplicationDbContext dbContext;


		public UserRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public async Task CreateAsync(User entity)
		{
			dbContext.Add(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task DeleteFirstAsync(User entity)
		{
			dbContext.Remove(entity);


			await dbContext.SaveChangesAsync();
		}

		public async Task<User> GetFirstByAsync(Expression<Func<User, bool>> predicate)
		{
			return await dbContext.Users.FirstOrDefaultAsync(predicate);
		}

		public async Task UpdateAsync(User entity)
		{
			dbContext.Add(entity);


			await dbContext.SaveChangesAsync();
		}
	}
}
