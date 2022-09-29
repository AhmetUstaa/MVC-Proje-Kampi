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
        ICategoryDal _categordal;
        public CategoryManager(ICategoryDal categordal)
        {
            _categordal = categordal;
        }

        public void CategoryAdd(Category category)
        {
            _categordal.Insert(category);
        }

        public List<Category> GetList()
        {
            return _categordal.List();
        }

    }
}