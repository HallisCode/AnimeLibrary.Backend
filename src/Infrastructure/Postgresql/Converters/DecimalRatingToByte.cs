using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Postgresql.Converters
{
	public class DecimalRatingToByte : ValueConverter<DecimalRating, byte>
	{
		public DecimalRatingToByte() : base(rating => rating.Value, _byte => new DecimalRating(_byte)) { }
	}
}
