using Application.DTO.Registry;
using Application.Exceptions.CRUD;
using Application.IServices;
using Application.Utils;
using Database.IUnitOfWork;
using Domain.Entities.Auth;
using Domain.Entities.User_;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Application.Services
{
	/// <summary>
	/// Сервис регистрации. Отвечает за регистрацию пользователя.
	/// </summary>
	public class RegistryService : IRegistryService
	{
		protected IUnitOfWork dbcontext;


		public RegistryService(IUnitOfWork dbcontext)
		{
			this.dbcontext = dbcontext;

		}


		public async Task RegistryAsync(RegistryRequest request)
		{
			string email;

			string password;

			// Хэшируем почту и пароль
			using (SHA256 sha256 = SHA256.Create())
			{
				email = SHA256Util.EncryptToString(request.Email.ToLower(), sha256);

				password = SHA256Util.EncryptToString(request.Password, sha256);
			}

			// Проверяем что пользователя с такой почтой нету
			Security otherSecurity = await dbcontext.Security.GetFirstByAsync((security => security.Email == email));

			if (otherSecurity is not null) throw new AlreadyExistException("Пользователь с таким email уже зарегестрирован.");

			// Проверяем что пользователя с таким username нету
			User otherUser = await dbcontext.User.GetFirstByAsync((user => user.Username == request.Username));

			if (otherUser is not null) throw new AlreadyExistException("Данный username уже занят.");

			// Создаём необходимые сущности при регистрации пользователя
			User user = new User(username: request.Username);

			Security security = new Security();

		}
	}
}
