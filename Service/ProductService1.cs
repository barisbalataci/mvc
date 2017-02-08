using Nortwind.Bussiness.Abstract;
using Nortwind.Bussiness.DependencyResolver.Ninject;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nortwind.Entities.ComplexType;
using Nortwind.Bussiness.UnitOfWorks;
using Nortwind.Service;

namespace Nortwind.Service
{
    public class ProductService1 :IProductService1 
    {
        private readonly IProductService _productService;
        private readonly UnitWork unit;

        public ProductService1()
        {
            _productService = InstanceFactory<Nortwind.Bussiness.Abstract.IProductService>.GetInstance();
            unit= new UnitWork();
           
        }
     
        public Product GetById(int id)
        {
            return _productService.GetById(id);            
            
            //return unit.ProductRepository.Get(m => m.Id == id);
        }

     

        
    }
}
