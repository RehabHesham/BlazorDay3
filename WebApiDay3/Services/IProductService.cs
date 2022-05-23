using SharedModels;
using System.Collections.Generic;

namespace WebApiDay3.Services
{
    public interface IProductService
    {
        int Create(Product product);
        int Delete(int id);
        List<Product> GetAll();
        Product GetProductById(int id);
        int Update(int id, Product product);
    }
}