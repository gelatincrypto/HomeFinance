using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeFinance.UI.Model;
using HomeFinance.UI.Repositories;
using Microsoft.AspNetCore.Components;

namespace HomeFinance.UI.Pages
{
    public partial class UpdateOperation
    {
        private OperationModel _operation;
        private List<CategoryModel> _categories = new();

        [Inject]
        IOperationRepository OperationRepository { get; set; }
        [Inject]
        public ICategoryRepository CategoryRepository { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }
        [Parameter]
        public string Id { get; set; }

        private string _selectedId;
        protected override async Task OnInitializedAsync()
        {
            _operation = await OperationRepository.GetAsync(Id);
            _categories = await CategoryRepository.GetAsync();
        }
        private async Task UpdateAsync()
        {
            int selectId = int.Parse(_selectedId);
            var selectedCategory = _categories.First(category => category.Id == selectId);
            _operation.CategoryIncomeOrExpense = selectedCategory.IncomeOrExpense;
            _operation.CategoryId = selectId;
            await OperationRepository.UpdateAsync(_operation);
            Navigation.NavigateTo($"/operations");
        }

        private void Back()
        {
            Navigation.NavigateTo($"/operations");
        }
    }
}