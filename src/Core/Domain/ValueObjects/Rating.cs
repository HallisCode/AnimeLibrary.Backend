using System;

namespace Domain.ValueObjects
{
	public record Rating(int Value) : IComparable<Rating>, IComparable
	{

		public int CompareTo(Rating other)
		{
			if (this.Value < other.Value) return -1;

			if (this.Value == other.Value) return 0;

			return 1;
		}

		public int CompareTo(object obj)
		{
			return -1;
		}
	}
}
