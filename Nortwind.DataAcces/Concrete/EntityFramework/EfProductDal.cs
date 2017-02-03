using Nortwind.DataAcces.Abstract;
using Nortwind.DataAcces.Concrete.EntityFramework.Contexts;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nortwind.Entities.ComplexType;

namespace Nortwind.DataAcces.Concrete.EntityFramework
{
    class EfProductDal : EfEntitityRepositoryBase<Product, NortwindContext>, IProductDal
    {
        public List<ProductDetail> GetProductDetails()
        {
            using (var context=new NortwindContext())
            {
                throw new NotImplementedException();
            }
        }

        public int GetProducutsCountByCategory(int? categoryId)
        {
            using (var context = new NortwindContext())
            {
                if (categoryId == null)
                {
                    return context.Products.Count();
                }
                else return context.Products.Count(p => p.CategoryId == categoryId);
            }
        }
    }
}
