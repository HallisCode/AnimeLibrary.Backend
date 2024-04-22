using FluentValidation;


namespace Domain.ValidationRules.Book_
{
	public static class BookDescriptionRule
	{
		public static IRuleBuilderOptions<T, string> BookDescription<T>(this IRuleBuilder<T, string> ruleBuilder)
		{
			return ruleBuilder.MaximumLength(10024);
		}
	}
}
