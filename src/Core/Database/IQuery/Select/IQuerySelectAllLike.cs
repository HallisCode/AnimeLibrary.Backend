using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Database.IQuery.Select
{
	public interface IQuerySelectAllLike<TEntity>
	{
		Task<List<TEntity>> GetAllByLikeAsync(
			string matchingField, string pattern,
			int take, int offset,
			Expression<Func<TEntity, object>> orderBy,
			params Expression<Func<TEntity, object>>[] thenBy
		);


		Task<List<TEntity>> GetAllByLikeAsync(string matchingField, string pattern, int take, int offset);
	}
}
