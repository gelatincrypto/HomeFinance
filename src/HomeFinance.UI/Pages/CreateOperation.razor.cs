using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeFinance.UI.Model;
using HomeFinance.UI.Repositories;
using Microsoft.AspNetCore.Components;

namespace HomeFinance.UI.Pages
{
    public partial class CreateOperation
    {
        private readonly OperationModel _operation = new() { Date = DateTime.Now.Date};
        private List<CategoryModel> _categories = new();

        [Inject]
        public IOperationRepository OperationRepository { get; set; }

        [Inject]
        public ICategoryRepository CategoryRepository { get; set; }
        [Inject]
        public NavigationManager Navigation { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _categories = await CategoryRepository.GetAsync();
            await base.OnInitializedAsync();
        }

        private async Task CreateAsync()
        {
            var selectedCategory = _categories.First(category => category.Id == _operation.CategoryId);
            _operation.CategoryIncomeOrExpense = selectedCategory.IncomeOrExpense;
            _operation.CategoryName = selectedCategory.Name;
            await OperationRepository.CreateAsync(_operation);
            Navigation.NavigateTo($"/operations");
        }

        private void Back()
        {
            Navigation.NavigateTo($"/operations");
        }
    }
}