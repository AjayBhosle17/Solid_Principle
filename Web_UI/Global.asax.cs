using AutoMapper;
using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web_UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

           


            // add krna padega
            Mapper.Initialize(configure =>
            configure.AddProfile<MappingProfile>());

            AreaRegistration.RegisterAllAreas();

            UnityConfig.RegisterComponents();

            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //Configure log4net

            log4net.Config.XmlConfigurator.Configure();
        }
    }
}
