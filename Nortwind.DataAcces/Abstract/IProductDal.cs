using Project.Shared.ComplexType;
using Project.Shared.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataLayer.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();

        int GetProducutsCountByCategory(int? categoryId);
    }
}
