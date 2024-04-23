using Database.IUnitOfWork;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;

namespace Postgresql.UnitOfWork
{
	public class Transaction : ITransaction
	{
		private bool disposed = false;

		protected IDbContextTransaction transaction;

		public Transaction(IDbContextTransaction transaction)
		{
			this.transaction = transaction;
		}

		public async Task CommitAsync()
		{
			await transaction.CommitAsync();
		}

		public async Task RollBackAsync()
		{
			await transaction.RollbackAsync();
		}

		public async Task SaveChangesAsync()
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			Dispose(true);

			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					transaction.Dispose();
				}

				disposed = true;
			}
		}

		~Transaction()
		{
			Dispose(false);
		}
	}
}
