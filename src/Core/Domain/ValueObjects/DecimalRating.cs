using System;

namespace Domain.ValueObjects
{
	/// <summary>
	/// Описывает сущность десятичной оценки. Может принимать значение от 0 до 10 включительно.
	/// </summary>
	public record DecimalRating : IComparable<DecimalRating>, IComparable
	{
		public byte Value { get; init; }

		public DecimalRating(byte value)
		{
			Value = GetValidatedValue(value);
		}

		public DecimalRating(int value)
		{
			Value = GetValidatedValue((byte)value);
		}

		private byte GetValidatedValue(byte value)
		{
			if (value < 0) return 0;

			else if (value > 10) return 10;

			return value;
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

		public static implicit operator DecimalRating(byte value)
		{
			return new DecimalRating(value);
		}
	}
}
