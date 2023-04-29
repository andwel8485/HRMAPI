using System;
using Onboarding.Infrastructure.Data;
using Onboarding.ApplicationCore.Contract.Repository;
using Microsoft.EntityFrameworkCore;

namespace Onboarding.Infrastructure.Repository
{
	public class BaseRepository<T>:IBaseRepository<T> where T:class
	{
        private readonly OnboardingDbContext _context;
		public BaseRepository(OnboardingDbContext onboardingDbContext)
		{
            _context = onboardingDbContext;
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

