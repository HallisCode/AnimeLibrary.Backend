using Application.DTO.Registry;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface IRegistryService
    {
        Task RegistryAsync(RegistryRequest request);
    }
}
