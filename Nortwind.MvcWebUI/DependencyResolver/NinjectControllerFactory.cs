using Ninject;
using Nortwind.Bussiness.Abstract;
using Nortwind.Bussiness.Concrete.Managers;
using Nortwind.DataAcces.Abstract;
using Nortwind.DataAcces.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Nortwind.MvcWebUI.DependencyResolver
{ 
    public class NinjectControllerFactory:DefaultControllerFactory

    {
        private IKernel _kernel;
        public NinjectControllerFactory()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IProductService>().To<ProductManager>().InSingletonScope();
            _kernel.Bind<IProductDal>().To<EfProductDal>().InSingletonScope();
            _kernel.Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            _kernel.Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();
        }
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_kernel.Get(controllerType);
        }
    }
}