using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HomeFinance.Domain.Core;
using HomeFinance.Infrastructure.Data.Interfaces;
using HomeFinance.Infrastructure.Data.Paging;
using Microsoft.EntityFrameworkCore;

namespace HomeFinance.Infrastructure.Data.Repository
{
    public class OperationRepository : IOperationRepository
    {
        private readonly HomeFinanceContext _dbContext;
        private readonly DbSet<Operation> _dbSet;

        public OperationRepository(HomeFinanceContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<Operation>();
        }

        public async Task<PagedList<Operation>> GetAllAsync(PagingParameters pagingParameters)
        {
            return await PagedList<Operation>.ToPagedList(
                _dbSet
                    .Include(operation => operation.Category)
                    .AsNoTracking()
                    .OrderBy(x => x.Date),
                pagingParameters.PageNumber,
                pagingParameters.PageSize);
        }

        public async Task CreateAsync(Operation item)
        {
            _dbContext.Set<Category>().Attach(item.Category);
            await _dbSet.AddAsync(item);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Operation item)
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

        public async Task<Operation> GetAsync(long id)
        {
            var entity = await
                (from operation in _dbSet
                 where operation.Id == id
                 select operation)
                .FirstOrDefaultAsync();

            return entity;
        }

        public async Task<bool> ExistAsync(Expression<Func<Operation, bool>> filterExpression)
        {
            return await _dbSet.AnyAsync(filterExpression);
        }
    }
}