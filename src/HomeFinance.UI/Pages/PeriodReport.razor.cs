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
    public partial class PeriodReport
    {
        private PeriodReportModel PeriodReportModel { get; } = new() { StartDay = DateTime.Now, EndDay = DateTime.Now, ReportTable = new ReportTableModel() };
        private MetaData MetaData { get; set; } = new();
        private readonly PagingParameters _pagingParameters = new();

        [Inject]
        public IReportRepository ReportRepository { get; set; }

        private async Task GetReport(bool updateTotal = true)
        {
            var startDay = PeriodReportModel.StartDay.ToInvariantCultureString();
            var endDay = PeriodReportModel.EndDay.ToInvariantCultureString();

            if (updateTotal)
                PeriodReportModel.ReportTable.TotalAmount = await ReportRepository.GetSumAsync(startDay, endDay);
            var pagingResponse = await ReportRepository.GetTransactionsAsync(_pagingParameters, startDay, endDay);
            PeriodReportModel.ReportTable.Operations = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }

        private async Task SelectedPage(int page)
        {
            _pagingParameters.PageNumber = page;
            await GetReport(false);
        }
    }
}