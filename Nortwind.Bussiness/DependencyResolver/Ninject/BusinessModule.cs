using Ninject.Modules;
using Project.Root.Abstract;

using Project.DataLayer.Abstract;
using Project.DataLayer.Concrete.EntityFramework;
using Project.Root.Concrete;

namespace Project.Root.DependencyResolver.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IServiceBase>().To<ServiceBase>().InSingletonScope();
            //Bind<IProductService>().To<ProductManager>().InSingletonScope();
            //Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            //Bind<ILanguageService>().To<LanguageManager>().InSingletonScope();
            //Bind<ILanguageWordService>().To<LanguageWordManager>().InSingletonScope();
            //Bind<IVProductService>().To<VProductManager>().InSingletonScope();
            //Bind<IOrderSalesService>().To<OrderSalesManager>().InSingletonScope();
            //Bind<IUserService>().To<UserManager>().InSingletonScope();

            
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