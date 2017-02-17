using Project.Shared.DataTypes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DataLayer.Concrete.EntityFramework.Contexts;
using Project.DataLayer.DataAccess.Abstract;

namespace Project.DataLayer.Concrete.EntityFramework

{
    public class EfCustomerDal:EfEntitityRepositoryBase<Customer,NortwindContext>,ICustomerDal
    {
    }
}
