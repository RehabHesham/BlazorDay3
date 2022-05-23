using BlazorDay3.Services;
using Microsoft.AspNetCore.Components;
using SharedModels;
using System.Threading.Tasks;

namespace BlazorDay3.ProductComponents
{
    public partial class ProductDetails
    {
        [Parameter]
        public int id { get; set; }
        [Inject]
        public IService<ProductDTO> prodService { get; set; }

        public ProductDTO product { get; set; }

        protected override async Task OnInitializedAsync()
        {
            product = await prodService.GetByID(id);
            await base.OnInitializedAsync();
        }
    }
}
