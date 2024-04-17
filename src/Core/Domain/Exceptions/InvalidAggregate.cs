using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
	public class InvalidAggregate : DomainException
	{
		public InvalidAggregate(string message) : base(message)
		{
		}

		public InvalidAggregate(string message, Exception innerException) : base(message, innerException) { }
	}
}
