using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public internal interface ICategoryDal
    {
        //CRUD 
        // Type Name();
        List<Category> List();
    }
}
