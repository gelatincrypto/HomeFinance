using System.Collections.Generic;
using System.Threading.Tasks;
using HomeFinance.Infrastructure.Data.Paging;
using HomeFinance.Services.Business.Pagination;
using HomeFinance.UI.Model;
using HomeFinance.UI.Repositories;
using Microsoft.AspNetCore.Components;

namespace HomeFinance.UI.Pages
{
    public partial class Operations
    {
        [Inject]
        public IOperationRepository OperationRepository { get; set; }

        private List<OperationModel> OperationsModels { get; set; } = new();
        private MetaData MetaData { get; set; } = new();
        private readonly PagingParameters _pagingParameters = new();

        protected override async Task OnInitializedAsync()
        {
            await GetOperations();
            await base.OnInitializedAsync();
        }

        private async Task GetOperations()
        {
            var pagingResponse = await OperationRepository.GetAsync(_pagingParameters);
            OperationsModels = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }

        private async Task SelectedPage(int page)
        {
            _pagingParameters.PageNumber = page;
            await GetOperations();
        }

        private async Task DeleteOperation(long id)
        {
            await OperationRepository.DeleteAsync(id);
            await OnInitializedAsync();
        }
    }
}