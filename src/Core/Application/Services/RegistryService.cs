using Application.DTO.Registry;
using Application.IServices;
using Database.IUnitOfWork;
using FluentValidation;
using System.Threading.Tasks;

namespace Application.Services
{
	public class RegistryService : IRegistryService
	{
		protected IUnitOfWork dbcontext;

		protected IValidator<RegistryRequest> validatorRegistry;


		public RegistryService(IUnitOfWork dbcontext, IValidator<RegistryRequest> validatorRegistry)
		{
			this.dbcontext = dbcontext;

			this.validatorRegistry = validatorRegistry;
		}


		public Task RegistryAsync(RegistryRequest request)
		{

		}
	}
}
