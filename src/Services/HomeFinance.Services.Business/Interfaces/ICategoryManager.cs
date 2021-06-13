using System.Collections.Generic;
using System.Threading.Tasks;
using HomeFinance.Services.Business.DTO;

namespace HomeFinance.Services.Business.Interfaces
{
    public interface ICategoryManager
    {
        Task<IEnumerable<CategoryDTO>> GetAllAsync();
        Task<CategoryDTO> GetAsync(long id);
        Task<bool> CreateAsync(CategoryDTO item);
        Task UpdateAsync(long id, CategoryDTO item);
        Task DeleteAsync(long id);
    }
}