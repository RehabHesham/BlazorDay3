using SharedModels;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorDay3.Services
{
    public class ProductService : IService<ProductDTO>
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync("api/Products/" + id);
        }

        public async Task<List<ProductDTO>> GetAll()
        {
            return await httpClient.GetFromJsonAsync<List<ProductDTO>>("api/Products");
        }

        public async Task<ProductDTO> GetByID(int id)
        {
            return await httpClient.GetFromJsonAsync<ProductDTO>("api/Products/" + id);
        }

        public async Task Insert(ProductDTO item)
        {
            await httpClient.PostAsJsonAsync<ProductDTO>("api/Products", item);
        }

        public async Task Update(int id, ProductDTO item)
        {
            await httpClient.PutAsJsonAsync<ProductDTO>("api/Products/" + id, item);
        }
    }
}
