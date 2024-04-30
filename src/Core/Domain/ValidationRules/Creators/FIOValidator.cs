using FluentValidation;
using System.Text.RegularExpressions;


namespace Domain.ValidationRules.Creators
{
	public static class FIOValidator
	{
		private static Regex allowedSymbols = new Regex("^[a-zA-Zа-яА-ЯёЁ]+$");

		public static IRuleBuilderOptionsConditions<T, string> Name<T>(this IRuleBuilder<T, string> ruleBuilder)
		{
			return ruleBuilder.Custom((field, context) =>
			{
				if (field.Length > 32)
				{
					context.AddFailure("Длина не может быть больше 32 символов.");
				}

				if (!allowedSymbols.IsMatch(field))
				{
					context.AddFailure("Может содержать только буквы русского и латинского алфавита.");
				}
			});
		}
	}
}
