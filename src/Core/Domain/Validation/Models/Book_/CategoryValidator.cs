using Domain.Entities.Classification;
using FluentValidation;


namespace Domain.Validation.Models
{
	public class CategoryValidator : AbstractValidator<Category>
	{
		public CategoryValidator()
		{
			RuleFor(category => category.Title).NotEmpty().MaximumLength(32);
		}
	}
}
