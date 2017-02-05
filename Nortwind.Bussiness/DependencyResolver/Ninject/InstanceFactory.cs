using Ninject;

namespace Nortwind.Bussiness.DependencyResolver.Ninject
{
    public class InstanceFactory<T>
    {
        public static T GetInstance()
        {
            var kernel = new StandardKernel(new BusinessModule());

            return kernel.Get<T>();
        }
    }
}
