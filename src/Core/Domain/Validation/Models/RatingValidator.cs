using Domain.Entities.Book_;
using FluentValidation;

namespace Domain.Validation.Models
{
	public class RatingValidator : AbstractValidator<Rating>
	{
		public RatingValidator()
		{
			RuleFor(rating => rating.Score).InclusiveBetween(new ValueObjects.Rating(0), new ValueObjects.Rating(10));
		}
	}
}
