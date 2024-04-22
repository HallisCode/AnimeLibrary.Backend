using FluentValidation;


namespace Domain.ValidationRules.Book_
{
	public static class BookTitleRule
	{
		public static IRuleBuilderOptions<T, string> BookTitle<T>(this IRuleBuilder<T, string> ruleBuilder)
		{
			return ruleBuilder.MinimumLength(1).MaximumLength(256);
		}
	}
}
