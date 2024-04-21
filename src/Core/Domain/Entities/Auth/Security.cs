using Domain.Validation.Models;
using FluentValidation;

namespace Domain.Entities.Auth
{

	public class Security : Entity<ulong>
	{
		public string Email { get; private set; }

		public string Password { get; private set; }


		// Relationships
		public long UserID { get; private set; }


		// Logic
		public Security(string email, string password)
		{
			Email = email;

			Password = password;

			Validate();
		}

		public void Update(string email = null, string password = null)
		{
			if (email is not null) Email = email;

			if (password is not null) Password = password;

			Validate();
		}

		protected override void Validate()
		{
			IValidator<Security> validator = new SecurityValidator();

			validator.ValidateAndThrow(this);
		}
	}
}
