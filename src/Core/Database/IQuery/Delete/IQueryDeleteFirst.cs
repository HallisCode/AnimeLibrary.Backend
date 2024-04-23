using System.Threading.Tasks;


namespace Database.IQuery.Delete
{
    public interface IQueryDeleteFirst<TEntity>
    {
        Task DeleteFirstByAsync(TEntity entity);
    }
}
