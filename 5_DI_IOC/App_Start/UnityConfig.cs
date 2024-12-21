using _5_DI_IOC.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace _5_DI_IOC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IUserData, UserModel>();
            container.RegisterType<IDemo,UserDemo>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}