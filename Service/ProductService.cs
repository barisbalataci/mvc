using Nortwind.Bussiness.Abstract;
using Nortwind.Bussiness.DependencyResolver.Ninject;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nortwind.Entities.ComplexType;

namespace Nortwind.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductService _productService;

        public ProductService()
        {
            _productService = InstanceFactory<IProductService>.GetInstance();
        }
     
        public Product GetById(int id)
        {
            return _productService.GetById(id);
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productService.GetByCategory(categoryId);
        }

       
        
        public void Add(Product product)
        {
            _productService.Add(product);
        }

        public void Update(Product product)
        {
            _productService.Update(product);
        }

        public void Delete(Product product)
        {
            _productService.Delete(product);
        }

        public List<Product> GetAll(ProductFilter productFilter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByProductName(string productName)
        {
            throw new NotImplementedException();
        }

        public int GetProductsCountByCategory(int? categoryId)
        {
            throw new NotImplementedException();
        }

        
    }
}
