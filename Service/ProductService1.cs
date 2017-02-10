using Project.ServerBase.Abstract;
using Project.ServerBase.DependencyResolver.Ninject;
using Project.Shared.DataTypes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.ServerBase.UnitOfWorks;
using Project.Shared;

namespace Project.Server
{
    public class ProductService1 :UnitWork ,IProductService1
    {
        private readonly IProductService _productService;
        //private readonly UnitWork unit;

        public ProductService1()
        {
            _productService = InstanceFactory<IProductService>.GetInstance();
            //unit= new UnitWork();
           
        }
     
        public Product GetById(int id)
        {
            return _productService.GetById(id);     
                   
            
            //return unit.ProductRepository.Get(m => m.Id == id);
        }

     

        
    }
}
