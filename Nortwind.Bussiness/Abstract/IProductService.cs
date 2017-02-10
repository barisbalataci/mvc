using Project.Shared;
using Project.Shared.DataTypes.ComplexType;
using Project.Shared.DataTypes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Project.ServerBase.Abstract
{
    [ServiceContract()]
    public interface IProductService
    {
        List<Product> GetAll(ProductFilter productFilter);
        [OperationContract()]
        Product GetById(int id);
        List<Product> GetByCategory(int categoryId);
        List<Product> GetByProductName(string productName);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        int GetProductsCountByCategory(int? categoryId);

    }
}
