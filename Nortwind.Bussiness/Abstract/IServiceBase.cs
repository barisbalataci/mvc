using Project.DataLayer.Concrete.EntityFramework;
using Project.DataLayer.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Root.Abstract
{
    public interface IServiceBase:IDisposable
    {
        EfProductDal ProductDAL { get; }
        EfCategoryDal CategoryDAL { get; }
        EfUserDal UserDAL { get; }
        NortwindContext Context { get; }
         void SaveAll();
    }
}
