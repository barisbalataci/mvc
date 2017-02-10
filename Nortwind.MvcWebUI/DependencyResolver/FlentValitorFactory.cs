using FluentValidation;
using Ninject;
using Project.ServerBase.ValidationRules.FluentValidation;
using Project.Shared.Concrete;
using System;

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