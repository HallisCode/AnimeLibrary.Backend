using Application.DTO.Registry;
using Application.Exceptions.CRUD;
using Application.IServices;
using Application.Utils;
using Database.IUnitOfWork;
using Domain.Entities.Auth;
using Domain.Entities.User_;
using System;
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

			bool isEmailExist = (await dbcontext.Security.GetFirstByAsync((security => security.Email == email))) == null;

			if (isEmailExist) throw new AlreadyExistException("Пользователь с таким email уже зарегестрирован.");


			// Проверяем что пользователя с таким username нету

			bool isUsernameClaimed = (await dbcontext.User.GetFirstByAsync((user => user.Username.ToLower() == request.Username))) == null;

			if (isUsernameClaimed) throw new AlreadyExistException("Данный username уже занят.");


			// Создаём транзакцию на сохранение сущностей

			Guid tempGuid = Guid.NewGuid();

			using (ITransaction transaction = dbcontext.BeginTransaction())
			{
				User user = new User(username: tempGuid.ToString());
				await dbcontext.User.CreateAsync(user);
				await transaction.SaveChangesAsync();

				Security security = new Security(email: email, password: password, userID: user.ID);
				await dbcontext.Security.CreateAsync(security);
				await transaction.SaveChangesAsync();

				await transaction.CommitAsync();
			}

		}
	}
}
