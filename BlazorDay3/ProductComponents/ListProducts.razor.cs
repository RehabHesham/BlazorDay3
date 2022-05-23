using SharedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDay3.ProductComponents
{
    public partial class ListProducts
    {
        public List<ProductDTO> products { get; set; }
        protected override async Task OnInitializedAsync()
        {
            products = await prodService.GetAll();
            Console.WriteLine(products.Count);
            await base.OnInitializedAsync();
        }
    }
}
