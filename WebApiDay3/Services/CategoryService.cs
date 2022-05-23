using SharedModels;
using System.Collections.Generic;
using System.Linq;
using WebApiDay3.Models;

namespace WebApiDay3.Services
{
    public class categorieservice : Icategorieservice
    {
        private readonly myDBcontext context;

        public categorieservice(myDBcontext _context)
        {
            this.context = _context;
        }
        public List<Category> GetAll()
        {
            return context.categories.ToList();
        }
        public Category GetCategoryById(int id)
        {
            return context.categories.SingleOrDefault(p => p.Id == id);
        }
        public int Create(Category category)
        {
            context.categories.Add(category);
            return context.SaveChanges();
        }
        public int Update(int id, Category category)
        {
            Category oldCategory = GetCategoryById(id);
            if (oldCategory != null)
            {
                oldCategory.Name = category.Name;
                return context.SaveChanges();
            }
            return -1;
        }
        public int Delete(int id)
        {
            Category category = GetCategoryById(id);
            context.categories.Remove(category);
            return context.SaveChanges();
        }
    }
}
