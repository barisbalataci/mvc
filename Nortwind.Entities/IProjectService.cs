using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Project.Shared.DataTypes.Entities;
using Project.Shared.DataTypes.ComplexType;

namespace Project.Shared
{
    [ServiceContract()]
    public interface IProjectService
    {
        
        [OperationContract()]
        List<Product> GetAll(ProductFilter productFilter);
        [OperationContract()]
        Product GetById(int id);
        [OperationContract()]
        List<Product> GetByCategory(int categoryId);
        [OperationContract()]
        List<Product> GetByProductName(string productName);
        [OperationContract()]
        void Add(Product product);
        [OperationContract()]
        void Update(Product product);
        [OperationContract()]
        void Delete(Product product);
        [OperationContract()]
        int GetProductsCountByCategory(int? categoryId);
        //[OperationContract()]
        List<Category> GetAll();
        [OperationContract()]
        User GetByUserNameAndPassword(User user);
    }
}
