using FluentValidation;
using Ninject;
using Nortwind.Bussiness.ValidationRules.FluentValidation;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nortwind.MvcWebUI.DependencyResolver
{
    public class FlentValitorFactory:ValidatorFactoryBase
    {
        private IKernel _kernel;
        public FlentValitorFactory()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IValidator<Product>>().To<ProductValidator>().InSingletonScope();
        }
        public override IValidator CreateInstance(Type validatorType)
        {
            return (validatorType == null) ? null : (IValidator)_kernel.TryGet(validatorType);
        }
    }
}