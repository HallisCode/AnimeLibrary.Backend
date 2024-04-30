using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphQL.VariableConfugiration
{
	public static class ConfigurationPostgresql
	{
		/// <summary>
		/// Формирует строку подключения к Postgresql из переменных окружения. <br/>
		/// В случае если они пустые - подтягивает настройки с файла конфигурации.
		/// </summary>
		/// <exception cref="PostgresqlConfiguredException"></exception>
		/// <param name="builder"></param>
		/// <returns></returns>
		public static string GetPostgrsqlConnectionString(this WebApplicationBuilder builder)
		{
			string username, password, port, database, host;


			string postgresql = "Connections:Postgresql";

			username = builder.Configuration[$"{postgresql}:Username"];

			password = builder.Configuration[$"{postgresql}:Password"];

			port = builder.Configuration[$"{postgresql}:Port"];

			database = builder.Configuration[$"{postgresql}:Database"];

			host = builder.Configuration[$"{postgresql}:Host"];


			if (string.IsNullOrEmpty(username)) username = Environment.GetEnvironmentVariable("POSTGRES_USER");

			if (string.IsNullOrEmpty(password)) password = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD");

			if (string.IsNullOrEmpty(database)) database = Environment.GetEnvironmentVariable("POSTGRES_DATABASE");

			if (string.IsNullOrEmpty(host)) host = Environment.GetEnvironmentVariable("POSTGRES_HOST");

			if (string.IsNullOrEmpty(port)) port = Environment.GetEnvironmentVariable("POSTGRES_PORT");


			List<string> nullVariableNames = new List<string>();

			if (string.IsNullOrEmpty(username)) nullVariableNames.Add(nameof(username));

			if (string.IsNullOrEmpty(password)) nullVariableNames.Add(nameof(password));

			if (string.IsNullOrEmpty(database)) nullVariableNames.Add(nameof(database));

			if (string.IsNullOrEmpty(host)) nullVariableNames.Add(nameof(host));

			if (string.IsNullOrEmpty(port)) nullVariableNames.Add(nameof(port));


			if (nullVariableNames.Count > 0)
			{
				throw new PostgresqlConfiguredException($"Переменные : {string.Join(", ", nullVariableNames)} для подключения к Postgresql не заданы.");
			}


			return $"Server={host};Port={port};Database={database};Username={username};Password={password}";
		}

		public class PostgresqlConfiguredException : Exception
		{
			public PostgresqlConfiguredException(string message) : base(message)
			{
			}

			public PostgresqlConfiguredException(string message, Exception innerException) : base(message, innerException)
			{
			}
		}
	}
}
