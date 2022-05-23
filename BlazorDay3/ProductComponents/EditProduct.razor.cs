using Microsoft.AspNetCore.Components;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorDay3.ProductComponents
{
    public partial class EditProduct
    {
        [Parameter]
        public int id { get; set; }
        [Inject]
        public NavigationManager navManager { get; set; }
        public ProductDTO product { get; set; }
        public List<Category> categories { get; set; }

        protected override async Task OnInitializedAsync()
        {
            product = await prodService.GetByID(id);
            categories = await catService.GetAll();
            await base.OnInitializedAsync();
        }

        public void SaveProduct()
        {
            prodService.Update(id,product);
            Console.WriteLine("Data Served Success");
            navManager.NavigateTo("/Products");
        }
    }
}
