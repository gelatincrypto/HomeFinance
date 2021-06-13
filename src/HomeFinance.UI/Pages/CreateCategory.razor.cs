using System.Threading.Tasks;
using HomeFinance.UI.Model;
using HomeFinance.UI.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace HomeFinance.UI.Pages
{
    public partial class CreateCategory
    {
        private readonly CreateOrUpdateCategoryModel _category = new();

        [Inject]
        public ICategoryRepository CategoryRepository { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }
        [Inject]
        public IJSRuntime Js { get; set; }

        private void Back()
        {
            Navigation.NavigateTo($"/categories");
        }

        private async Task CreateAsync()
        {
            if (await CategoryRepository.CreateAsync(_category))
            {
                Navigation.NavigateTo($"/categories");
            }
            else
            {
                await Js.InvokeVoidAsync("alert", "Category with same name already exist.");
                Navigation.NavigateTo($"/createCategory");
            }
        }
    }
}