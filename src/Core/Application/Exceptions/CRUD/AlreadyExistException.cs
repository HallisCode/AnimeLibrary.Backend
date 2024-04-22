using System;

namespace Application.Exceptions.CRUD
{
	public class AlreadyExistException : ApplicationException
	{
		public AlreadyExistException(string message) : base(message)
		{

		}

		public AlreadyExistException(string message, Exception innerException) : base(message, innerException)
		{

		}
	}
}
