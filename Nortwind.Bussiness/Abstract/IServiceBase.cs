using Project.DataLayer.Abstract;
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
        IProductDal ProductDAL { get; }
        ICategoryDal CategoryDAL { get; }
        IUserDal UserDAL { get; }
        NortwindContext Context { get; }
        void SaveAll();
    }
}
