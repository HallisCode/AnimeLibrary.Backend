using System;
using System.Threading.Tasks;

namespace Application.DTO.ReturningType
{
	/// <summary>
	/// Описывает класс, который является унифицированым возвращаемым значением для всех методов логики.<br/>
	/// Это вполне логично, ведь сервис на деле, возращает "извещение", что у нас некорректный запрос или что-либо еще.
	/// </summary>
	public class OperationResult : IOperationResult
	{
		public bool IsSuccess { get; init; }

		public Exception Error { get; init; }


		protected OperationResult() { }

		// Static methods
		public static OperationResult Succes()
		{
			return new OperationResult()
			{
				IsSuccess = true,
				Error = null
			};
		}

		public static OperationResult Failure(Exception exception)
		{
			return new OperationResult()
			{
				IsSuccess = false,
				Error = exception
			};
		}

		public static OperationResult<TValue> Success<TValue>(TValue value)
		{
			return OperationResult<TValue>.Success(value);
		}


		// Operators
		public static implicit operator OperationResult(Exception exception)
		{
			return Failure(exception);
		}

		public static implicit operator Task<OperationResult>(OperationResult operationResult)
		{
			return Task.FromResult(operationResult);
		}
	}

	/// <summary>
	/// Описывает класс, который является унифицированым возвращаемым значением для всех методов логики.<br/>
	/// Дополнительно содержит ожидаемое возвращаемое значение типа <typeparamref name="TValue"/>.
	/// </summary>
	/// <typeparam name="TValue"></typeparam>
	public class OperationResult<TValue> : IOperationResult<TValue>
	{
		public bool IsSuccess { get; init; }

		public Exception Error { get; init; }

		public TValue Value { get; init; }


		public readonly Type _valueType;

		public Type ValueType { get => _valueType; }


		protected OperationResult()
		{
			_valueType = Value.GetType();
		}

		// Static methods
		public static OperationResult<TValue> Success(TValue value)
		{
			return new OperationResult<TValue>()
			{
				IsSuccess = true,
				Error = null,
				Value = value
			};
		}

		public static OperationResult<TValue> Failure(Exception exception)
		{
			return new OperationResult<TValue>()
			{
				IsSuccess = false,
				Error = exception,
			};
		}

		// Operators
		public static implicit operator OperationResult<TValue>(TValue value)
		{
			return Success(value);
		}

		public static implicit operator TValue(OperationResult<TValue> operationResult)
		{
			return operationResult.Value;
		}

		public static implicit operator OperationResult<TValue>(OperationResult operationResult)
		{
			return new OperationResult<TValue>()
			{
				IsSuccess = operationResult.IsSuccess,
				Error = operationResult.Error
			};
		}

		public static implicit operator OperationResult<TValue>(Exception exception)
		{
			return Failure(exception);
		}

		public static implicit operator Task<OperationResult<TValue>>(OperationResult<TValue> operationResult)
		{
			return Task.FromResult(operationResult);
		}
	}
}
