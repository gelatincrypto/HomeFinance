using System.Collections.Generic;
using System.Threading.Tasks;
using HomeFinance.UI.Model;

namespace HomeFinance.UI.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<CategoryModel>> GetAsync();
        Task<CreateOrUpdateCategoryModel> GetAsync(string id);
        Task<bool> CreateAsync(CreateOrUpdateCategoryModel category);
        Task DeleteAsync(long id);
        Task<bool> UpdateAsync(CreateOrUpdateCategoryModel category);
    }
}