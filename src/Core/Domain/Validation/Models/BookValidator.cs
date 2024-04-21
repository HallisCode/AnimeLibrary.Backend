using Domain.IEntites.Book_;
using FluentValidation;
using System;

namespace Domain.Validation.Models
{
	public class BookValidator : AbstractValidator<IBook>
	{
		/// <summary>
		/// Валидатор для модели <see cref="IBook"/>.
		/// </summary>
		/// <param name="isCreating">Флаг, указывающий создается ли новая книга. 
		/// Если значение <b>true</b>, то поля не могут быть null или пустыми</param>
		public BookValidator(bool isCreating = true)
		{
			IRuleBuilder<IBook, string> title = RuleFor(book => book.Title).MinimumLength(1).MaximumLength(256);

			IRuleBuilder<IBook, string> isbn13 = RuleFor(book => book.ISBN13).Length(13);

			IRuleBuilder<IBook, string> description = RuleFor(book => book.Description).MaximumLength(5012);

			IRuleBuilder<IBook, int> yearRelese = RuleFor(book => book.YearRelease).GreaterThan(DateTime.UtcNow.Year);

			if (isCreating)
			{
				title.NotEmpty();

				isbn13.NotEmpty();

				yearRelese.NotEmpty();
			}
		}
	}
}
