using Project.DataLayer.Abstract;
using Project.DataLayer.Concrete.EntityFramework.Contexts;
using Project.Shared.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Shared.ComplexType;

namespace Project.DataLayer.Concrete.EntityFramework
{
    public class EfProductDal : EfEntitityRepositoryBase<Product, NortwindContext>, IProductDal
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
