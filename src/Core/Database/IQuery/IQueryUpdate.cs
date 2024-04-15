using System.Threading.Tasks;

namespace Database.IQuery
{
	public interface IQueryUpdate<TEntity>
	{
		Task UpdateAsync(TEntity entity);
	}
}
