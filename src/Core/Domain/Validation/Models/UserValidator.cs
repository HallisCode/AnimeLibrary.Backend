using Domain.Entities.User_;
using Domain.Validation.Properties;
using FluentValidation;

namespace Domain.Validation.Models
{
	public class UserValidator : AbstractValidator<User>
	{
		/// <summary>
		/// Валидатор для модели <see cref="IUser"/>.
		/// </summary>
		public UserValidator()
		{
			RuleFor(user => user.Username).Username();
		}
	}
}
