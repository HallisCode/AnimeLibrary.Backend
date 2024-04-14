using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities._Auth
{
	public class Security : Entity
	{
		public string Email { get; set; }

		public string Password { get; set; }

		#region Relationships
		public long UserID { get; set; }
		#endregion
	}
}
