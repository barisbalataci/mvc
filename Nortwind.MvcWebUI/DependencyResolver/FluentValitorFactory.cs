using FluentValidation;
using Ninject;
using Project.Root.ValidationRules.FluentValidation;
using Project.Shared.DataTypes.Entities;
using System;

namespace Nortwind.MvcWebUI.DependencyResolver
{
    public class FluentValitorFactory:ValidatorFactoryBase
    {
        private IKernel _kernel;
        public FluentValitorFactory()
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