using FluentValidation;


namespace Domain.ValidationRules.Book_
{
	public static class ReviewContentRule
	{
		public static IRuleBuilderOptions<T, string> ReviewContent<T>(this IRuleBuilder<T, string> ruleBuilder)
		{
			return ruleBuilder.MinimumLength(256).MaximumLength(5012); ;
		}
	}
}
