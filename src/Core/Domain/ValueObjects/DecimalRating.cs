using System;

namespace Domain.ValueObjects
{
	/// <summary>
	/// Описывает сущность десятичной оценки. Может принимать значение от 0 до 10 включительно.
	/// </summary>
	public record DecimalRating : IComparable<DecimalRating>, IComparable
	{
		public int Value { get; init; }


		public DecimalRating(int value)
		{
			if (value < 0) Value = 0;

			if (value > 10) Value = 10;
		}

		public int CompareTo(DecimalRating other)
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
