using Database.IRepositories.Auth;
using Database.IRepositories.Book_;
using Database.IRepositories.Classification;
using Database.IRepositories.Creators;
using Database.IRepositories.User_;
using Database.IUnitOfWork;
using System;
using System.Threading.Tasks;

namespace Postgresql.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private bool disposed = false;

		private ApplicationDbContext dbContext;


		public UnitOfWork(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}


		public ISecurityRepository Security => throw new NotImplementedException();

		public ISessionRepository Session => throw new NotImplementedException();

		public IBookRepository Book => throw new NotImplementedException();

		public IRatingRepository Rating => throw new NotImplementedException();

		public IReviewRepository Review => throw new NotImplementedException();

		public ICategoryRepository Category => throw new NotImplementedException();

		public IAuthorRepository Author => throw new NotImplementedException();

		public IPublisherRepository Publisher => throw new NotImplementedException();

		public IMarkedBookRepository MarkedBook => throw new NotImplementedException();

		public IUserRepository User => throw new NotImplementedException();

		public async Task<ITransaction> BeginTransactionAsync()
		{
			return new Transaction(await dbContext.Database.BeginTransactionAsync());
		}
	}
}
