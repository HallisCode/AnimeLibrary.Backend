using FluentValidation;
using System.Linq;
using System.Text.RegularExpressions;


namespace Domain.ValidationRules.Auth
{
	public static class PasswordValidator
	{
		private static Regex specialSymbol = new Regex(@"[~!@#$%^&*()_+=:;?><.,|/\\]");

		public static IRuleBuilderOptionsConditions<T, string> Password<T>(this IRuleBuilder<T, string> ruleBuilder)
		{
			return ruleBuilder.Custom((field, context) =>
			{

				if (!field.Any(letter => char.IsUpper(letter)))
				{
					context.AddFailure("Должен содержать 1 заглавную букву.");
				}

				if (!field.Any(letter => char.IsDigit(letter)))
				{
					context.AddFailure("Должен содержать 1 цифру.");
				}

				if (!specialSymbol.IsMatch(field))
				{
					context.AddFailure("Должен содержать 1 спец. символ.");
				}

				if (field.Length < 8)
				{
					context.AddFailure("Длина не может быть меньше 8 символов.");
				}

				if (field.Length > 64)
				{
					context.AddFailure("Длина не может быть больше 64 символов.");
				}

			});
		}
	}
}
