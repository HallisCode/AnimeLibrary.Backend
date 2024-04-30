using FluentValidation;
using System.Text.RegularExpressions;


namespace Domain.ValidationRules.User_
{
	public static class UsernameRule
	{
		private static Regex allowedSymbols = new Regex("^[a-zA-Z0-9_]+$");

		private static Regex duplicateUnderscore = new Regex("^(?!.*__).*$");


		public static IRuleBuilderOptionsConditions<T, string> Username<T>(this IRuleBuilder<T, string> ruleBuilder)
		{
			return ruleBuilder.Custom((field, context) =>
			{
				if (!char.IsLetter(field[0]))
				{
					context.AddFailure("Должен начинаться с буквы.");
				}

				if (!allowedSymbols.IsMatch(field))
				{
					context.AddFailure("Может содержать только латинские буквы, цифры и знак нижнего подчеркивания.");
				}

				if (!duplicateUnderscore.IsMatch(field))
				{
					context.AddFailure("Знак нижнего подчеркивания не должен идти более одного раза подряд.");
				}

				if (field.Length < 5)
				{
					context.AddFailure("Длина не может быть меньше 5 символов.");
				}

				if (field.Length > 32)
				{
					context.AddFailure("Длина не может быть больше 32 символов.");
				}
			});
		}
	}


}
