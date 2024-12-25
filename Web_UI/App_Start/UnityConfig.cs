using BAL;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Web_UI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            // container.RegisterType<ProductDbContext>  // bcoz dbcontext nahi to to bal ka db ke sath connection hai

            ProjectDependency.RegisterServices(ref container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}