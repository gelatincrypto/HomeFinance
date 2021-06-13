using System.Threading.Tasks;
using HomeFinance.Infrastructure.Data.Paging;
using HomeFinance.UI.Features;
using HomeFinance.UI.Model;

namespace HomeFinance.UI.Repositories
{
    public interface IReportRepository
    {
        Task<TotalAmountModel> GetSumAsync(string day);
        Task<TotalAmountModel> GetSumAsync(string startDay, string endDay);

        Task<PagingResponse<OperationModel>> GetTransactionsAsync(PagingParameters pagingParameters, string day);

        Task<PagingResponse<OperationModel>> GetTransactionsAsync(PagingParameters pagingParameters, string startDay,
            string endDay);

    }
}