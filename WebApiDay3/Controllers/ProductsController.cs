using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedModels;
using WebApiDay3.Models;
using WebApiDay3.Services;

namespace WebApiDay3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> Getproducts()
        {
            List<Product> prod = productService.GetAll();
            List<ProductDTO> products = new List<ProductDTO>();
            foreach (Product product in prod)
            {
                products.Add(new ProductDTO()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Image = product.Image,
                    Cat_Id = product.Cat_Id,
                    Cat_Name = product.category.Name
                });
            }
            return products;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<ProductDTO> GetProduct(int id)
        {
            var product = productService.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return new ProductDTO()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Image = product.Image,
                Cat_Id = product.Cat_Id,
                Cat_Name = product.category.Name
            };
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            int result = productService.Update(id, product);
            if(result <= 0)
            {
                return StatusCode(500);
            }
            return NoContent();
        }

        // POST: api/Products
        [HttpPost]
        public ActionResult<Product> PostProduct(Product product)
        {
            productService.Create(product);

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            productService.Delete(id);
            return NoContent();
        }
    }
}
