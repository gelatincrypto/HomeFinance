using System.Threading.Tasks;
using HomeFinance.Infrastructure.Data.Paging;
using HomeFinance.UI.Features;
using HomeFinance.UI.Model;

namespace HomeFinance.UI.Repositories
{
    public interface IOperationRepository
    {
        Task<PagingResponse<OperationModel>> GetAsync(PagingParameters pagingParameters);
        Task<OperationModel> GetAsync(string id);
        Task CreateAsync(OperationModel category);
        Task DeleteAsync(long id);
        Task UpdateAsync(OperationModel category);
    }
}
