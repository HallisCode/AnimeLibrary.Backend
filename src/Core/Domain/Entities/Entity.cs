namespace Domain.Entities
{
	public abstract class Entity<TKeyType>
	{
		public TKeyType ID { get; private set; }

		protected abstract void Validate();
	}
}
