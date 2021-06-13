using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using HomeFinance.UI.Model;

namespace HomeFinance.UI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly HttpClient _client;

        public CategoryRepository(IHttpClientFactory factory)
        {
            _client = factory.CreateClient("api");
        }

        public async Task<List<CategoryModel>> GetAsync()
        {
            var response = await _client.GetAsync("categories");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            return JsonSerializer.Deserialize<List<CategoryModel>>(content,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<CreateOrUpdateCategoryModel> GetAsync(string id)
        {
            var response = await _client.GetAsync($"categories/{id}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }

            var category = JsonSerializer.Deserialize<CreateOrUpdateCategoryModel>(content,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return category;
        }

        public async Task<bool> CreateAsync(CreateOrUpdateCategoryModel category)
        {
            var content = JsonSerializer.Serialize(category);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var postResult = await _client.PostAsync("categories", bodyContent);
            if (postResult.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }

            var postContent = await postResult.Content.ReadAsStringAsync();
            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }

            return true;
        }

        public async Task DeleteAsync(long id)
        {
            var deleteResult = await _client.DeleteAsync($"categories/{id}");
            var deleteContent = await deleteResult.Content.ReadAsStringAsync();
            if (!deleteResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(deleteContent);
            }
        }

        public async Task<bool> UpdateAsync(CreateOrUpdateCategoryModel category)
        {
            var content = JsonSerializer.Serialize(category);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var putResult = await _client.PutAsync($"categories/{category.Id}", bodyContent);
            if (putResult.StatusCode == HttpStatusCode.BadRequest)
            {
                return false;
            }

            var putContent = await putResult.Content.ReadAsStringAsync();
            if (!putResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(putContent);
            }

            return true;
        }
    }
}
