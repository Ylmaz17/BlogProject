using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepositorty;
        public CategoryManager()
        {
            efCategoryRepositorty = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            efCategoryRepositorty.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            efCategoryRepositorty.Delete(category);
        }

        public Category GetById(int id)
        {
            return efCategoryRepositorty.GetById(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRepositorty.GetlistAll();
        }

        public void UpdateCategory(Category category)
        {
            efCategoryRepositorty.Update(category);
        }
    }
}
