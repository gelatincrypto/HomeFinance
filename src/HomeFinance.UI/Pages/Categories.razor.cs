using System.Collections.Generic;
using System.Threading.Tasks;
using HomeFinance.UI.Model;
using HomeFinance.UI.Repositories;
using Microsoft.AspNetCore.Components;

namespace HomeFinance.UI.Pages
{
    public partial class Categories
    {
        private List<CategoryModel> CategoryModels { get; set; } = new();

        [Inject]
        public ICategoryRepository CategoryRepository { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await GetCategories();
            await base.OnInitializedAsync();
        }

        private async Task GetCategories()
        {
            CategoryModels = await CategoryRepository.GetAsync();
        }

        private async Task DeleteCategory(long id)
        {
            await CategoryRepository.DeleteAsync(id);
            await OnInitializedAsync();
        }
    }
}