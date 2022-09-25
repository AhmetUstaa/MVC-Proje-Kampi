using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        Generic_Reporsitory<Category> repo = new Generic_Reporsitory<Category>();

        public List<Category> GetAllBL() 
        {
            return repo.List();
        }
        public void CategoryAddBL(Category p) 
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName >= 51) 
            {
                //hata mesajı
            }
            else 
            {
                repo.Insert(p);
            }
        }


    }
}
