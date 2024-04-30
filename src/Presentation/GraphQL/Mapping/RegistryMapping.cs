
namespace GraphQL.Mapping
{
	public static class RegistryMapping
	{
		public static Application.DTO.Registry.RegistryRequest ToApplicationDTO(this DTO.Registry.RegistryRequest source)
		{
			return new Application.DTO.Registry.RegistryRequest(
				Email: source.Email,
				Password: source.Password,
				Username: source.Username
				);
		}
	}
}
