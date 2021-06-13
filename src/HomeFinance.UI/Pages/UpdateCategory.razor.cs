using System.Threading.Tasks;
using HomeFinance.UI.Model;
using HomeFinance.UI.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace HomeFinance.UI.Pages
{
    public partial class UpdateCategory
    {
        private CreateOrUpdateCategoryModel _category;
        [Inject]
        ICategoryRepository CategoryRepository { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }
        [Inject]
        public IJSRuntime Js { get; set; }
        [Parameter]
        public string Id { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _category = await CategoryRepository.GetAsync(Id);
        }
        private async Task UpdateAsync()
        {
            if (await CategoryRepository.UpdateAsync(_category))
            {
                Navigation.NavigateTo($"/categories");
            }
            else
            {
                await Js.InvokeVoidAsync("alert", "Category with same name already exist.");
                Navigation.NavigateTo($"/updateCategory/{_category.Id}");
            }
        }

        private void Back()
        {
            Navigation.NavigateTo($"/categories");
        }
    }
}