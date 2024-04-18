namespace Domain.Entities
{
	public class Entity<TKeyType>
	{
		public TKeyType ID { get; private set; }
	}
}
