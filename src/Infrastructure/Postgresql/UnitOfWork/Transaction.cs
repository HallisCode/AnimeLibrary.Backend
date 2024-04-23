using Database.IUnitOfWork;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Data;
using System.Threading.Tasks;

namespace Postgresql.UnitOfWork
{
	public class Transaction : ITransaction
	{
		protected IDbContextTransaction transaction;

		public Transaction(IDbContextTransaction transaction)
		{
			this.transaction = transaction;
		}

		public Task CommitAsync()
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public Task RollBackAsync()
		{
			throw new NotImplementedException();
		}

		public Task SaveChangesAsync()
		{
			throw new NotImplementedException();
		}
	}
}
