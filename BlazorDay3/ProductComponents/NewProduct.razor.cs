using BlazorDay3.Services;
using Microsoft.AspNetCore.Components;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDay3.ProductComponents
{
    public partial class NewProduct
    {
        [Inject]
        public NavigationManager navManager { get; set; }
        [Inject]
        public IService<Category> catService { get; set; }
        [Inject]
        public IService<ProductDTO> prodService { get; set; }
        public List<Category> categories { get; set; }

        public ProductDTO product ;

        protected override async Task OnInitializedAsync()
        {
            product = new ProductDTO();
            categories = await catService.GetAll();
            Console.WriteLine(categories.Count);
            await base.OnInitializedAsync();
        }

        public void SaveProduct()
        {
            prodService.Insert(product);
            Console.WriteLine("Data Served Success");
            navManager.NavigateTo("/Products");
        }
    }
}
