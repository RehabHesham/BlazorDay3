using BlazorDay3.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDay3.ProductComponents
{
    public partial class ListProducts
    {
        [Inject]
        public NavigationManager navManager { get; set; }

        public List<ProductDTO> products { get; set; }
        protected override async Task OnInitializedAsync()
        {
            products = await prodService.GetAll();
            Console.WriteLine(products.Count);
            await base.OnInitializedAsync();
        }
        public async void delete(int id)
        {
            if (!await JSRuntime.InvokeAsync<bool>("confirm", "Are you sure you want to delete the product?"))
                return;
            await prodService.Delete(id);
            navManager.NavigateTo("/Products");
        }
    }
}
