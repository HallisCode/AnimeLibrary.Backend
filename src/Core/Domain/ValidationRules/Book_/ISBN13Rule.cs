using FluentValidation;


namespace Domain.ValidationRules.Book_
{
	public static class ISBN13Rule
	{
		public static IRuleBuilderOptions<T, string> ISBN13<T>(this IRuleBuilder<T, string> ruleBuilder)
		{
			return ruleBuilder.Length(13);
		}
	}
}
