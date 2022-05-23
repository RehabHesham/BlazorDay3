using Microsoft.EntityFrameworkCore;
using SharedModels;
using System.Collections.Generic;
using System.Linq;
using WebApiDay3.Models;

namespace WebApiDay3.Services
{
    public class ProductService : IProductService
    {
        private readonly myDBcontext context;

        public ProductService(myDBcontext _context)
        {
            this.context = _context;
        }

        public List<Product> GetAll()
        {
            return context.products.Include(p=>p.category).ToList();
        }
        public Product GetProductById(int id)
        {
            return context.products.Include(p => p.category).SingleOrDefault(p => p.Id == id);
        }
        public int Create(Product product)
        {
            context.products.Add(product);
            return context.SaveChanges();
        }
        public int Update(int id, Product product)
        {
            Product oldProduct = GetProductById(id);
            if (oldProduct != null)
            {
                oldProduct.Name = product.Name;
                oldProduct.Description = product.Description;
                oldProduct.Image = product.Image;
                oldProduct.Price = product.Price;
                oldProduct.Cat_Id = product.Cat_Id;
                return context.SaveChanges();
            }
            return -1;
        }
        public int Delete(int id)
        {
            Product product = GetProductById(id);
            context.products.Remove(product);
            return context.SaveChanges();
        }
    }

}
