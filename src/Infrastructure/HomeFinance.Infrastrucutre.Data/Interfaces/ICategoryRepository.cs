using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HomeFinance.Domain.Core;

namespace HomeFinance.Infrastructure.Data.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        public Task CreateAsync(Category element);
        public Task UpdateAsync(Category element);
        public Task DeleteAsync(long id);
        public Task<Category> GetAsync(long id);
        public Task<bool> ExistAsync(Expression<Func<Category,bool>> filterExpression);
    }
}