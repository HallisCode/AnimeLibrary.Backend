using System.ComponentModel.DataAnnotations;

namespace GraphQL.DTO.Registry
{
	public class RegistryRequest
	{
		[Required]
		public string Email { get; set; }
		[Required]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }


		public RegistryRequest() { }
	}
}
