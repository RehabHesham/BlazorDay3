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
    public class CategoriesController : ControllerBase
    {
        private readonly Icategorieservice categorieservice;

        public CategoriesController(Icategorieservice categorieservice)
        {
            this.categorieservice = categorieservice;
        }

        // GET: api/Categories
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            return categorieservice.GetAll();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public ActionResult<Category> GetCategory(int id)
        {
            var Category = categorieservice.GetCategoryById(id);

            if (Category == null)
            {
                return NotFound();
            }

            return Category;
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public IActionResult PutCategory(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            int result = categorieservice.Update(id, category);
            if (result <= 0)
            {
                return StatusCode(500);
            }
            return NoContent();
        }

        // POST: api/Categories
        [HttpPost]
        public ActionResult<Category> PostCategory(Category category)
        {
            categorieservice.Create(category);

            return CreatedAtAction("GetCategory", new { id = category.Id }, category);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            categorieservice.Delete(id);
            return NoContent();
        }
    }
}
