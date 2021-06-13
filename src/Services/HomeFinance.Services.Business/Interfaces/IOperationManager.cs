using System.Threading.Tasks;
using HomeFinance.Services.Business.DTO;
using HomeFinance.Infrastructure.Data.Paging;

namespace HomeFinance.Services.Business.Interfaces
{
    public interface IOperationManager
    {
        Task<PagedList<OperationDTO>> GetAllAsync(PagingParameters pagingParameters);
        Task<OperationDTO> GetAsync(long id);
        Task CreateAsync(OperationDTO item);
        Task<bool> UpdateAsync(long id, OperationDTO item);
        Task DeleteAsync(long id);
    }
}