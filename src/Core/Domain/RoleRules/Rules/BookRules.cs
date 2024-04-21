namespace Domain.RoleRules.Rules
{
	public static class BookRules
	{
		public static readonly Rule Add = new Rule(nameof(Add));

		public static readonly Rule Edit = new Rule(nameof(Edit));

		public static readonly Rule Delete = new Rule(nameof(Delete));
	}
}
