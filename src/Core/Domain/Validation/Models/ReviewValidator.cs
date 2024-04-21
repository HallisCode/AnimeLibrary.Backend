using Domain.Entities.Book_;
using FluentValidation;


namespace Domain.Validation.Models
{
	public class ReviewValidator : AbstractValidator<Review>
	{
		public ReviewValidator()
		{
			RuleFor(review => review.Content).NotEmpty().MinimumLength(256).MaximumLength(5012);
		}
	}
}
