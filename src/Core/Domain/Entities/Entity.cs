namespace Domain.Entities
{
	public class Entity<TKeyType>
	{
		public TKeyType Id { get; private set; }
	}
}
