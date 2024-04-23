using System;
using System.Threading.Tasks;


namespace Database.IUnitOfWork
{
	public interface ITransaction : IDisposable
	{
		public Task SaveChangesAsync();

		public Task RollBackAsync();

		public Task CommitAsync();
	}
}
