using System;
using System.Threading.Tasks;
using HomeFinance.Domain.Core;
using HomeFinance.Infrastructure.Data.Model;
using HomeFinance.Infrastructure.Data.Paging;

namespace HomeFinance.Infrastructure.Data.Interfaces
{
    public interface IReportRepository
    {
        Task<Report> GetSumAsync(DateTime date);
        Task<Report> GetSumAsync(DateTime startDate, DateTime endDate);
        Task<PagedList<Operation>> GetOperationsAsync(DateTime date, PagingParameters pagingParameters);
        Task<PagedList<Operation>> GetOperationsAsync(DateTime startDate, DateTime endDate, PagingParameters pagingParameters);
    }
}