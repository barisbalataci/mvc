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
        
        List<Product> GetAll(ProductFilter productFilter);
        [OperationContract()]
        Product GetById(int id);
        List<Product> GetByCategory(int categoryId);
        List<Product> GetByProductName(string productName);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        int GetProductsCountByCategory(int? categoryId);
        List<Category> GetAll();
        User GetByUserNameAndPassword(User user);
    }
}
