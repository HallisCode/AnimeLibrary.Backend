using Domain.Entities.Auth;
using Domain.Entities.Book_;
using Domain.Validation.Properties;
using FluentValidation;
using System;

namespace Domain.Validation.Models.Auth
{
    public class SecurityValidator : AbstractValidator<Security>
    {
        /// <summary>
        /// Валидатор для модели <see cref="Security"/>.
        /// </summary>
        public SecurityValidator()
        {
            RuleFor(book => book.Email).NotEmpty().EmailAddress();

            RuleFor(book => book.Password).NotEmpty().Password();
        }
    }
}
