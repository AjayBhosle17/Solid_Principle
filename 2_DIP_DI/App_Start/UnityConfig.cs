using _2_DIP_DI.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace _2_DIP_DI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IUserModel, UserModel>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}