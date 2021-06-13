using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using HomeFinance.Domain.Core;
using HomeFinance.Infrastructure.Data.Paging;

namespace HomeFinance.Infrastructure.Data.Interfaces
{
    public interface IOperationRepository
    {
        Task<PagedList<Operation>> GetAllAsync(PagingParameters pagingParameters);
        public Task CreateAsync(Operation element);
        public Task UpdateAsync(Operation element);
        public Task DeleteAsync(long id);
        public Task<Operation> GetAsync(long id);
        public Task<bool> ExistAsync(Expression<Func<Operation, bool>> filterExpression);
    }
}