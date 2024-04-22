using System;
using System.Security.Cryptography;
using System.Text;


namespace Application.Utils
{
	public static class SHA256Util
	{

		/// <summary>
		/// Получает хэш данных <paramref name="data"/> с помощью алгоритма sha256, а затем переводит в кодировку base64.
		/// </summary>
		/// <returns>Зашифрованные данные в представлении base64 (строка).</returns>
		public static string EncryptToString(string data, SHA256 sha256)
		{
			return Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(data)));
		}
	}
}
