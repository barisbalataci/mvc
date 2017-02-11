using Project.Root.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Shared.DataTypes.ComplexType;
using Project.Shared.DataTypes.Entities;
using Project.DataLayer.Abstract;
using Project.Root.ValidationRules.FluentValidation;

namespace Project.Root.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        private UnitOfWorks.UnitWork unit;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
            unit = new UnitOfWorks.UnitWork();
        }
        public void Add(Product product)
        {
            FluentValidatorTool.Validate(new ProductValidator(), product);
            ProductNameCheck(product);
            _productDal.Add(product);
        }

        private void ProductNameCheck(Product product)
        {
            bool isThereAnyProductNameWithTheSameName = _productDal.GetList(p => p.ProductName == product.ProductName).Any();
            if (isThereAnyProductNameWithTheSameName)
            {
                throw new Exception("There is already a product with the same name.");
            }
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll(ProductFilter productFilter)
        {
            int? categoryId = productFilter.CategoryId;
            if (categoryId != null)
            {
                return _productDal.GetList(
                    filter: product => product.CategoryId == categoryId,
                    orderBy: o => o.OrderBy(product => product.Id),
                    page: productFilter.Page,
                    pageSize: productFilter.PageSize
                );
            }
            else
            {
                return _productDal.GetList(
                    orderBy: o => o.OrderBy(product => product.Id),
                    page: productFilter.Page,
                    pageSize: productFilter.PageSize
                );
            }
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId);
        }

        public Product GetById(int id)
        {
            return unit.ProductRepository.Get(m => m.Id == id);
            //return _productDal.Get(p => p.Id == id);
        }

        public List<Product> GetByProductName(string productName)
        {
            return _productDal.GetList(p => p.ProductName.Contains(productName));
        }

        public int GetProductsCountByCategory(int? categoryId)
        {
            return _productDal.GetProducutsCountByCategory(categoryId);
        }

        public void Update(Product product)
        {
            FluentValidatorTool.Validate(new ProductValidator(), product);
            //ProductNameCheck(product);
            _productDal.Update(product);
        }
    }
}
