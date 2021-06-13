using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HomeFinance.Domain.Core;
using HomeFinance.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HomeFinance.Infrastructure.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly HomeFinanceContext _dbContext;
        private readonly DbSet<Category> _dbSet;

        public CategoryRepository(HomeFinanceContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<Category>();
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _dbSet
                .AsNoTracking()
                .OrderBy(x => x.Id)
                .ToListAsync();
        }

        public async Task CreateAsync(Category item)
        {
            await _dbSet.AddAsync(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category item)
        {
            _dbContext.Update(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var item = await _dbSet.FindAsync(id);
            if (item == null)
                return;

            _dbSet.Remove(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Category> GetAsync(long id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity;
        }

        public async Task<bool> ExistAsync(Expression<Func<Category, bool>> filterExpression)
        {
            return await _dbSet.AnyAsync(filterExpression);
        }
    }
}