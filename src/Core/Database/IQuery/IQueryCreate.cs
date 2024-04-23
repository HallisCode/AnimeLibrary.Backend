using System.Threading.Tasks;

namespace Database.IQuery
{
	public interface IQueryCreate<TEntity>
	{
		Task CreateAsync(TEntity entity);
	}
}
