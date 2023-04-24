using System;
using Microsoft.EntityFrameworkCore;
using Recruiting.Infrastructure.Data;
using Recruiting.ApplicationCore.Contract.Repository;

namespace Recruiting.Infrastructure.Repository
{
	public class BaseRepository<T>:IBaseRepository<T> where T:class
	{
        private readonly RecruitingDbContext _context;
		public BaseRepository(RecruitingDbContext recruitingDbContext)
		{
            _context = recruitingDbContext;
		}

        public async Task<int> DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<int> InsertAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            return await _context.SaveChangesAsync();
        }
    }
}

