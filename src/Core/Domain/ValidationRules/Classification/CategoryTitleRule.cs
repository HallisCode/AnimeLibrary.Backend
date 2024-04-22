using FluentValidation;


namespace Domain.ValidationRules.Classification
{
	public static class CategoryTitleRule
	{
		public static IRuleBuilderOptions<T, string> CategoryTitle<T>(this IRuleBuilder<T, string> ruleBuilder)
		{
			return ruleBuilder.MaximumLength(32);
		}
	}
}
