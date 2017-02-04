using Nortwind.DataAcces.Abstract;
using Nortwind.DataAcces.Concrete.EntityFramework.Contexts;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nortwind.DataAcces.Concrete.EntityFramework
{
    
    public class EfUserDal: EfEntitityRepositoryBase<User, NortwindContext>, IUserDal
    {
    }
}
