using Project.Shared.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ServerBase.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
