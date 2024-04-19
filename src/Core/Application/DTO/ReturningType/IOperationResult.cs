using System;

namespace Application.DTO.ReturningType
{
	/// <summary>
	/// Описывает необходимые поля, для унифицированного возвращаемого типа.<br/>
	/// </summary>
	public interface IOperationResult
	{
		public bool IsSuccess { get; }

		public Exception Error { get; }
	}

	/// <summary>
	/// Описывает необходимые поля, для унифицированного возвращаемого типа.<br/>
	/// Дополнительно содержит ожидаемый возвращаемый тип <typeparamref name="TValue"/>.
	/// </summary>
	public interface IOperationResult<TValue> : IOperationResult
	{
		public TValue Value { get; }

		public Type ValueType { get; }
	}
}
