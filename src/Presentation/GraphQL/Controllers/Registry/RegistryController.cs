using Application.DTO.Registry;
using Application.IServices;
using GraphQL.AspNet.Attributes;
using GraphQL.AspNet.Controllers;
using GraphQL.AspNet.Interfaces.Controllers;
using GraphQL.DTO.Registry;
using GraphQL.Mapping;
using System.Threading.Tasks;

namespace GraphQL.Controllers.Registry
{
	public class RegistryController : GraphController
	{
		private IRegistryService registryService;


		public RegistryController(IRegistryService registryService)
		{
			this.registryService = registryService;
		}


		[MutationRoot("registry", typeof(bool))]
		public async Task<IGraphActionResult> Registry(DTO.Registry.RegistryRequest request)
		{
			await registryService.RegistryAsync(request.ToApplicationDTO());

			return this.Ok(true);
		}
	}
}
