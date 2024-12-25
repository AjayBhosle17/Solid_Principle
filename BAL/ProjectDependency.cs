using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace BAL
{
    public class ProjectDependency
    {
        public  static void RegisterServices(ref UnityContainer container)
        {
            container.RegisterType<ProductDBContext>();
            container.RegisterType<ICategoryRepo, CategoryRepository>();
            container.RegisterType<ICategoryBL, CategoryBL>();

            // dependecy add kr skta hu

        }
    }
}
