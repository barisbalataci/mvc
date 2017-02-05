using Ninject.Modules;
using Nortwind.Bussiness.Abstract;
using Nortwind.Bussiness.Concrete.Managers;
using Nortwind.DataAcces.Abstract;
using Nortwind.DataAcces.Concrete.EntityFramework;

namespace Nortwind.Bussiness.DependencyResolver.Ninject
{
    class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            //Bind<ILanguageService>().To<LanguageManager>().InSingletonScope();
            //Bind<ILanguageWordService>().To<LanguageWordManager>().InSingletonScope();
            //Bind<IVProductService>().To<VProductManager>().InSingletonScope();
            //Bind<IOrderSalesService>().To<OrderSalesManager>().InSingletonScope();
            Bind<IUserService>().To<UserManager>().InSingletonScope();
            
            Bind<IProductDal>().To<EfProductDal>().InSingletonScope();           
            Bind<ICategoryDal>().To<EfCategoryDal>().InSingletonScope();            
            Bind<IUserDal>().To<EfUserDal>().InSingletonScope();

            //Bind<IProductDal>().To<NhProductDal>().InSingletonScope();
            //Bind<ICategoryDal>().To<NhCategoryDal>().InSingletonScope();
            //Bind<ILanguageDal>().To<NhLanguageDal>().InSingletonScope();
            //Bind<ILanguageWordDal>().To<NhLanguageWordDal>().InSingletonScope();
            //Bind<IVProductDal>().To<NhVProductDal>().InSingletonScope();
            //Bind<IOrderSalesDal>().To<NhOrderSalesDal>().InSingletonScope();
            //Bind<IUserDal>().To<NhUserDal>().InSingletonScope();



            //Bind<NHibernateHelper>().To<SqlNHibernateHelper>().InSingletonScope();
        }
    }
}