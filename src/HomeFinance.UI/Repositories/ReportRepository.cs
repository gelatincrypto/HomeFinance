using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using HomeFinance.Infrastructure.Data.Paging;
using HomeFinance.Services.Business.Pagination;
using HomeFinance.UI.Features;
using HomeFinance.UI.Model;
using Microsoft.AspNetCore.WebUtilities;

namespace HomeFinance.UI.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly HttpClient _client;

        public ReportRepository(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("api");
        }

        public async Task<TotalAmountModel> GetSumAsync(string day)
        {
            return await GetSumFromApiAsync($"{day}");
        }

        public async Task<TotalAmountModel> GetSumAsync(string startDay, string endDay)
        {
            return await GetSumFromApiAsync($"{startDay}/{endDay}");
        }

        public async Task<PagingResponse<OperationModel>> GetTransactionsAsync(PagingParameters pagingParameters,
            string day)
        {
            return await GetTransactionsFromApiAsync(pagingParameters, $"{day}");
        }

        public async Task<PagingResponse<OperationModel>> GetTransactionsAsync(PagingParameters pagingParameters,
            string startDay, string endDay)
        {
            return await GetTransactionsFromApiAsync(pagingParameters, $"{startDay}/{endDay}");
        }

        private async Task<TotalAmountModel> GetSumFromApiAsync(string dateQuery)
        {
            var sumResponse = await _client.GetAsync($"report/{dateQuery}/total");
            var sumContent = await sumResponse.Content.ReadAsStringAsync();
            if (!sumResponse.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Reason: {sumResponse.ReasonPhrase}, Message: {sumContent}");
            }
            return JsonSerializer.Deserialize<TotalAmountModel>(sumContent, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        private async Task<PagingResponse<OperationModel>> GetTransactionsFromApiAsync(PagingParameters pagingParameters, string query)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = pagingParameters.PageNumber.ToString()
            };

            var response = await _client.GetAsync(QueryHelpers.AddQueryString($"report/{query}", queryStringParam));
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Reason: {response.ReasonPhrase}, Message: {content}");
            }

            var pagingResponse = new PagingResponse<OperationModel>
            {
                Items = JsonSerializer.Deserialize<List<OperationModel>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }),
                MetaData = JsonSerializer.Deserialize<MetaData>(response.Headers.GetValues("X-Pagination").First(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
            };
            return pagingResponse;
        }
    }
}