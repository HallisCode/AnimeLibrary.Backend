using Domain.ValueObjects;
using FluentValidation;


namespace Domain.ValidationRules.Classification
{
	public static class RatingRule
	{
		public static IRuleBuilderOptions<T, Rating> Rating<T>(this IRuleBuilder<T, Rating> ruleBuilder)
		{
			return ruleBuilder.InclusiveBetween(new ValueObjects.Rating(0), new ValueObjects.Rating(10)); ;
		}
	}
}
