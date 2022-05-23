using SharedModels;
using System.Collections.Generic;

namespace WebApiDay3.Services
{
    public interface Icategorieservice
    {
        int Create(Category category);
        int Delete(int id);
        List<Category> GetAll();
        Category GetCategoryById(int id);
        int Update(int id, Category category);
    }
}