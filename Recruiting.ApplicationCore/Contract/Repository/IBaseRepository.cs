using System;
namespace Recruiting.ApplicationCore.Contract.Repository
{
	public interface IBaseRepository<T> where T:class
	{
		public Task<int> InsertAsync(T entity);
        public Task<int> UpdateAsync(T entity);
        public Task<int> DeleteAsync(T entity);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T?> GetByIdAsync(int id);
    }
}

