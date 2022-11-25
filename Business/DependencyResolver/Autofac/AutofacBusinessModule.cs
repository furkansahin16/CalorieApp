using Autofac;
using Autofac.Extras.DynamicProxy;
using Base.Utilities.Interceptors;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Module = Autofac.Module;

namespace Business.DependencyResolver.Autofac
{
    public class AutofacBusinessModule : Module
    {

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<ProductTypeManager>().As<IProductTypeService>().SingleInstance();
            builder.RegisterType<ProductTypeDal>().As<IProductTypeDal>().SingleInstance();

            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<ProductDal>().As<IProductDal>().SingleInstance();

            builder.RegisterType<MealTypeManager>().As<IMealTypeService>().SingleInstance();
            builder.RegisterType<MealTypeDal>().As<IMealTypeDal>().SingleInstance();

            builder.RegisterType<MealManager>().As<IMealService>().SingleInstance();
            builder.RegisterType<MealDal>().As<IMealDal>().SingleInstance();

            builder.RegisterType<MealDetailManager>().As<IMealDetailService>().SingleInstance();
            builder.RegisterType<MealDetailDal>().As<IMealDetailDal>().SingleInstance();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

        }
    }
}
