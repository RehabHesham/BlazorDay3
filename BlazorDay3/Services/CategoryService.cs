using SharedModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;//exension method httpclient
using System.Threading.Tasks;

namespace BlazorDay3.Services
{
    public class CategoryService : IService<Category>
    {
        private readonly HttpClient httpClient;

        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync("api/Categories/" + id);
        }

        public async Task<List<Category>> GetAll()
        {
            return await httpClient.GetFromJsonAsync<List<Category>>("api/Categories");
        }

        public async Task<Category> GetByID(int id)
        {
            return await httpClient.GetFromJsonAsync<Category>("api/Categories/" + id);
        }

        public async Task Insert(Category item)
        {
            await httpClient.PostAsJsonAsync<Category>("api/Categories" , item);
        }

        public async Task Update(int id, Category item)
        {
            await httpClient.PutAsJsonAsync<Category>("api/Categories"+id, item);
        }
    }
}
