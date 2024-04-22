using Domain.ValueObjects;
using FluentValidation;


namespace Domain.ValidationRules.Classification
{
	public static class RatingRule
	{
		public static IRuleBuilderOptions<T, DecimalRating> Rating<T>(this IRuleBuilder<T, DecimalRating> ruleBuilder)
		{
			return ruleBuilder.InclusiveBetween(new ValueObjects.DecimalRating(0), new ValueObjects.DecimalRating(10)); ;
		}
	}
}
