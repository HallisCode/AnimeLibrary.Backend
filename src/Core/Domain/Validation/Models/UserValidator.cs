using Domain.IEntites.User_;
using Domain.Validation.Properties;
using FluentValidation;

namespace Domain.Validation.Models
{
	public class UserValidator : AbstractValidator<IUser>
	{
		/// <summary>
		/// Валидатор для модели <see cref="IUser"/>.
		/// </summary>
		/// <param name="isCreating">Флаг, указывающий создается ли новый пользователь. 
		/// Если значение <b>true</b>, то поля не могут быть null или пустыми</param>
		public UserValidator(bool isCreating = true)
		{
			IRuleBuilder<IUser, string> username = RuleFor(user => user.Username).Username();

			if (isCreating)
			{
				username.NotEmpty();
			}
		}
	}
}
