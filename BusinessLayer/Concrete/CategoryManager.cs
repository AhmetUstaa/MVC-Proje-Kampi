using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
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
        ICategoryDal _categorDal;
        public CategoryManager(ICategoryDal categordal)
        {
            _categorDal = categordal;
        }

        public void CategoryAdd(Category category)
        {
            _categorDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categorDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categorDal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categorDal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categorDal.List();
        }

    }
}