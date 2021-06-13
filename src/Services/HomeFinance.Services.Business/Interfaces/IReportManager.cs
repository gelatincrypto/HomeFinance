using System.Threading.Tasks;
using HomeFinance.Infrastructure.Data.Paging;
using HomeFinance.Services.Business.DTO;

namespace HomeFinance.Services.Business.Interfaces
{
    public interface IReportManager
    {
        Task<ReportDTO> GetSumAsync(string date);
        Task<ReportDTO> GetSumAsync(string startDate, string endDate);
        Task<PagedList<OperationDTO>> GetReportAsync(string date, PagingParameters pagingParameters);
        Task<PagedList<OperationDTO>> GetReportAsync(string startDate, string endDate, PagingParameters pagingParameters);
    }
}