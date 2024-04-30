using Application.IServices;
using Application.Services;
using Database.IUnitOfWork;
using GraphQL.AspNet.Configuration;
using GraphQL.VariableConfugiration;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Postgresql;
using Postgresql.UnitOfWork;

namespace GraphQL
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			//________________________
			// Конфигурация переменных
			//________________________

			string postgresql = builder.GetPostgrsqlConnectionString();

			//_____________________________
			// Подключение сервисов
			//_____________________________ 

			// GraphQl
			var schemaBuilder = builder.Services.AddGraphQL();

			// Сервисы логики
			builder.Services.AddScoped<IRegistryService, RegistryService>();

			// Репозитории и доступ к бд
			builder.Services.AddDbContext<ApplicationDbContext>(
				options => options.UseNpgsql(postgresql), ServiceLifetime.Transient
			);
			builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

			//_________________________________
			// Middlewares свойственные GraphQL
			//_________________________________

			var app = builder.Build();

			//________________________________
			// Подключение middlewares
			//________________________________

			// GraphQl
			app.UseGraphQL();

			app.Run();
		}
	}
}