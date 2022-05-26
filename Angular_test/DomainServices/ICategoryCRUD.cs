using Angular_test.Models;
using System.Collections.Generic;

namespace Angular_test.DomainServices
{
    public interface ICategoryCRUD
    {
        Category Add(CategoryModel model);    
        Category Update(CategoryModel model);
        void Delete(int id);
         
        Category GetById(int id);

        List<Category> GetAll();
    }
}
