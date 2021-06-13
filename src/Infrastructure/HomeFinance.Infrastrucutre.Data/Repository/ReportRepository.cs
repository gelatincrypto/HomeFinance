using System;
using System.Linq;
using System.Threading.Tasks;
using HomeFinance.Domain.Core;
using HomeFinance.Infrastructure.Data.Interfaces;
using HomeFinance.Infrastructure.Data.Model;
using HomeFinance.Infrastructure.Data.Paging;
using Microsoft.EntityFrameworkCore;

namespace HomeFinance.Infrastructure.Data.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly DbSet<Operation> _dbSet;

        public ReportRepository(HomeFinanceContext dbContext)
        {
            _dbSet = dbContext.Set<Operation>();
        }

        public async Task<Report> GetSumAsync(DateTime date)
        {
            var totalAmounts = await _dbSet
                .Where(x => x.Date == date)
                .GroupBy(operation => operation.Category.IncomeOrExpense)
                .Select(x =>
                    new
                    {
                        IncomeOrExpense = x.Key,
                        Sum = x.Sum(y => y.Amount)
                    })
                .ToListAsync();

            return new Report
            {
                ExpenseAmount = totalAmounts.FirstOrDefault(x => !x.IncomeOrExpense)?.Sum ?? 0,
                IncomeAmount = totalAmounts.FirstOrDefault(x => x.IncomeOrExpense)?.Sum ?? 0
            };
        }

        public async Task<Report> GetSumAsync(DateTime startDate, DateTime endDate)
        {
            var totalAmounts = await _dbSet
                .Where(operation => operation.Date >= startDate && operation.Date <= endDate)
                .GroupBy(operation => operation.Category.IncomeOrExpense)
                .Select(x =>
                    new
                    {
                        IncomeOrExpense = x.Key,
                        Sum = x.Sum(y => y.Amount)
                    })
                .ToListAsync();

            return new Report
            {
                ExpenseAmount = totalAmounts.FirstOrDefault(x => !x.IncomeOrExpense)?.Sum ?? 0,
                IncomeAmount = totalAmounts.FirstOrDefault(x => x.IncomeOrExpense)?.Sum ?? 0
            };
        }

        public async Task<PagedList<Operation>> GetOperationsAsync(DateTime date, PagingParameters pagingParameters)
        {
            var operations = _dbSet
                .Include(operation => operation.Category)
                .Where(operation => operation.Date == date)
                .AsNoTracking()
                .OrderBy(x => x.Date);

            return await PagedList<Operation>.ToPagedList(
                operations,
                pagingParameters.PageNumber,
                pagingParameters.PageSize);
        }

        public async Task<PagedList<Operation>> GetOperationsAsync(DateTime startDate, DateTime endDate, PagingParameters pagingParameters)
        {
            var operations = _dbSet
                .Include(operation => operation.Category)
                .Where(operation => operation.Date >= startDate && operation.Date <= endDate)
                .AsNoTracking()
                .OrderBy(x => x.Date);

            return await PagedList<Operation>.ToPagedList(
                operations,
                pagingParameters.PageNumber,
                pagingParameters.PageSize);
        }
    }
}
