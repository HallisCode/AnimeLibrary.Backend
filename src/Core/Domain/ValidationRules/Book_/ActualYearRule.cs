using FluentValidation;
using System;

namespace Domain.ValidationRules.Book_
{
	public static class ActualYearRule
	{
		public static IRuleBuilderOptions<T, DateOnly> BookDescription<T>(this IRuleBuilder<T, DateOnly> ruleBuilder)
		{
			return ruleBuilder.GreaterThan(DateOnly.FromDateTime(DateTime.UtcNow));
		}
	}
}
