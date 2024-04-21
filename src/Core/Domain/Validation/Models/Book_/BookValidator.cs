using Domain.Entities.Book_;
using FluentValidation;
using System;

namespace Domain.Validation.Models.Book_
{
    public class BookValidator : AbstractValidator<Book>
    {
        /// <summary>
        /// Валидатор для модели <see cref="IBook"/>.
        /// </summary>
        public BookValidator()
        {
            RuleFor(book => book.Title).NotEmpty().MinimumLength(1).MaximumLength(256);

            RuleFor(book => book.ISBN13).Length(13);

            RuleFor(book => book.Description).MaximumLength(10024);

            RuleFor(book => book.YearRelease).GreaterThan(DateTime.UtcNow.Year);
        }
    }
}
