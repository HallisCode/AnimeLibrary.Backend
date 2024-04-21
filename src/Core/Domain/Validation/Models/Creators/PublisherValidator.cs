using Domain.Entities.Creators;
using Domain.Validation.Properties;
using FluentValidation;

namespace Domain.Validation.Models.Creators
{
	public class PublisherValidator : AbstractValidator<Publisher>
	{
		public PublisherValidator()
		{
			RuleFor(pubsliher => pubsliher.Name).NotEmpty().Name();
		}
	}
}
