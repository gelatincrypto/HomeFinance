using System;
using System.Threading.Tasks;
using HomeFinance.Infrastructure.Data.Paging;
using HomeFinance.Services.Business.Pagination;
using HomeFinance.UI.Extensions;
using HomeFinance.UI.Model;
using HomeFinance.UI.Repositories;
using Microsoft.AspNetCore.Components;

namespace HomeFinance.UI.Pages
{
    public partial class DayReport
    {
        private DayReportModel DayReportModel { get; set; } = new() { Day = DateTime.Now.Date, ReportTable = new ReportTableModel()};
        private MetaData MetaData { get; set; } = new();
        private readonly PagingParameters _pagingParameters = new();

        [Inject]
        public IReportRepository ReportRepository { get; set; }

        private async Task SelectedPage(int page)
        {
            _pagingParameters.PageNumber = page;
            await GetReport(false);
        }

        private async Task GetReport(bool updateTotal = true)
        {
            var day = DayReportModel.Day.ToInvariantCultureString();

            if (updateTotal)
                DayReportModel.ReportTable.TotalAmount = await ReportRepository.GetSumAsync(day);
            var pagingResponse = await ReportRepository.GetTransactionsAsync(_pagingParameters, day);
            DayReportModel.ReportTable.Operations = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
    }
}