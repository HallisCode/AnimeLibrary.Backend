using System;
using System.Threading.Tasks;


namespace Database.IUnitOfWork
{
	public interface ITransaction : IDisposable
	{
		public Task RollBackAsync();

		public Task CommitAsync();
	}
}
