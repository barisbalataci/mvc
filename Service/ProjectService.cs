using Project.Root.Abstract;
using Project.Shared.DataTypes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Root.Concrete;
using Project.Shared;
using Project.Root.ValidationRules.FluentValidation;
using Project.Shared.DataTypes.ComplexType;
using Project.Server.DependencyResolver.Ninject;

namespace Project.Server
{
    public class ProjectService :IProjectService
    {
       // private readonly IProductService _productService;
        //private readonly UnitWork unit;
        private readonly IServiceBase _session;

        public ProjectService()
        {
            //_productService = InstanceFactory<IProductService>.GetInstance();

            _session = InstanceFactory<IServiceBase>.GetInstance();
            

        }

        public void Add(Product product)
        {
            FluentValidatorTool.Validate(new ProductValidator(), product);
            ProductNameCheck(product);
            _session.ProductDAL.Add(product);
        }

        private void ProductNameCheck(Product product)
        {
            bool isThereAnyProductNameWithTheSameName = _session.ProductDAL.GetList(p => p.ProductName == product.ProductName).Any();
            if (isThereAnyProductNameWithTheSameName)
            {
                throw new Exception("There is already a product with the same name.");
            }
        }

        public void Delete(Product product)
        {
            _session.ProductDAL.Delete(product);
        }

        public List<Product> GetAll(ProductFilter productFilter)
        {
            int? categoryId = productFilter.CategoryId;
            if (categoryId != null)
            {
                return _session.ProductDAL.GetList(
                    filter: product => product.CategoryId == categoryId,
                    orderBy: o => o.OrderBy(product => product.Id),
                    page: productFilter.Page,
                    pageSize: productFilter.PageSize
                );
            }
            else
            {
                return _session.ProductDAL.GetList(
                    orderBy: o => o.OrderBy(product => product.Id),
                    page: productFilter.Page,
                    pageSize: productFilter.PageSize
                );
            }
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _session.ProductDAL.GetList(p => p.CategoryId == categoryId);
        }

        public Product GetById(int id)
        {
            return _session.ProductDAL.Get(p => p.Id == id);
        }

        public List<Product> GetByProductName(string productName)
        {
            return _session.ProductDAL.GetList(p => p.ProductName.Contains(productName));
        }

        public int GetProductsCountByCategory(int? categoryId)
        {
            return _session.ProductDAL.GetProducutsCountByCategory(categoryId);
        }

        public void Update(Product product)
        {
            FluentValidatorTool.Validate(new ProductValidator(), product);            
            _session.ProductDAL.Update(product);
        }

        public List<Category> GetAllCategories()
        {
            return _session.CategoryDAL.GetList();
        }

        public User GetByUserNameAndPassword(User user)
        {
            return _session.UserDAL.Get(u => u.UserName == user.UserName && u.Password == user.Password);
        }

        //Customers
        public List<Customer> GetCustomerList()
        {
            return _session.CustomerDal.GetList();

        }



    }
}
