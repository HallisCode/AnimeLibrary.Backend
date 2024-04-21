using Domain.Entities.Creators;
using Domain.Validation.Properties;
using FluentValidation;
using System;

namespace Domain.Validation.Models.Creators
{
	public class AuthorValidator : AbstractValidator<Author>
	{
		public AuthorValidator()
		{
			RuleFor(author => author.Name).NotEmpty().Name();

			RuleFor(author => author.LastName).NotEmpty().Name();

			RuleFor(book => book.DateBirth).GreaterThan(DateOnly.FromDateTime(DateTime.UtcNow));

			RuleFor(book => book.DateDeath).GreaterThan(DateOnly.FromDateTime(DateTime.UtcNow));

			RuleFor(author => author.Description).MaximumLength(10024);
		}
	}
}
