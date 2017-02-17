using Project.Shared.DataTypes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DataLayer.Concrete.EntityFramework;
using Project.DataLayer.Concrete.EntityFramework.Contexts;
using System.Data;
using System.Transactions;
using Project.Root.Abstract;
using Project.Root;

using Project.DataLayer.DataAccess.Abstract;

namespace Project.Root.Concrete
{
    public class ServiceBaseEF : IServiceBase
    {
        private NortwindContext _context;
        private ICategoryDal _categoryDal;
        private IProductDal _productDal;
        private IUserDal _UserDal;
        private ICustomerDal _customerDal;
       
        public ICategoryDal CategoryDAL
        {
            get
            {
                if (_categoryDal == null)
                    _categoryDal = new EfCategoryDal();
                return _categoryDal;
            }
        }
        public IProductDal ProductDAL
        {
            get
            {
                if (_productDal == null)
                    _productDal = new EfProductDal();
                return _productDal;
            }
        }

        public IUserDal UserDAL
        {
            get
            {
                if (_UserDal == null)
                    _UserDal = new EfUserDal();
                return _UserDal;
            }
        }
        public ICustomerDal CustomerDal
        {
            get
            {
                if (_customerDal == null)
                    _customerDal = new EfCustomerDal();
                return _customerDal;
            }
        }

        public NortwindContext Context
        {
            get
            {
                if (_context == null)
                    _context = new NortwindContext();
                return _context;
            }
        }

        public void SaveAll()
        {
            using (TransactionScope tScope = new TransactionScope())
            {
                //_context.SaveChanges();
                tScope.Complete();
            }
        }
      
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
