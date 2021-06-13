using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HomeFinance.Infrastructure.Data.Paging;
using HomeFinance.Services.Business.Pagination;
using HomeFinance.UI.Features;
using HomeFinance.UI.Model;
using Microsoft.AspNetCore.WebUtilities;

namespace HomeFinance.UI.Repositories
{
    public class OperationRepository : IOperationRepository
    {
        private readonly HttpClient _client;

        public OperationRepository(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("api");
        }

        public async Task<PagingResponse<OperationModel>> GetAsync(PagingParameters pagingParameters)
        {
            var queryStringParam = new Dictionary<string, string>
            {
                ["pageNumber"] = pagingParameters.PageNumber.ToString()
            };

            var response = await _client.GetAsync(QueryHelpers.AddQueryString("operations", queryStringParam));
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var pagingResponse = new PagingResponse<OperationModel>
            {
                Items = JsonSerializer.Deserialize<List<OperationModel>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }),
                MetaData = JsonSerializer.Deserialize<MetaData>(response.Headers.GetValues("X-Pagination").First(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true })
            };

            return pagingResponse;
        }

        public async Task<OperationModel> GetAsync(string id)
        {
            var response = await _client.GetAsync($"operations/{id}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var operation = JsonSerializer.Deserialize<OperationModel>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return operation;
        }

        public async Task CreateAsync(OperationModel category)
        {
            var content = JsonSerializer.Serialize(category);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var postResult = await _client.PostAsync("operations", bodyContent);
            var postContent = await postResult.Content.ReadAsStringAsync();
            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }
        }

        public async Task DeleteAsync(long id)
        {
            var deleteResult = await _client.DeleteAsync($"operations/{id}");
            var deleteContent = await deleteResult.Content.ReadAsStringAsync();
            if (!deleteResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(deleteContent);
            }
        }

        public async Task UpdateAsync(OperationModel category)
        {
            var content = JsonSerializer.Serialize(category);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var putResult = await _client.PutAsync($"operations/{category.Id}", bodyContent);
            var putContent = await putResult.Content.ReadAsStringAsync();
            if (!putResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(putContent);
            }
        }
    }
}
