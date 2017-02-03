using Nortwind.Bussiness.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nortwind.Entities.Concrete;
using Nortwind.DataAcces.Abstract;

namespace Nortwind.Bussiness.Concrete.Managers
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
