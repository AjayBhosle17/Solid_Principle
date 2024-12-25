using AutoMapper;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{

    // automapper for conversion  
    // mapping profile ko golbal.asax file me dalna padega
    public class MappingProfile : Profile
    {
        public MappingProfile() { 
        
            CreateMap<Category,CategoryViewModel>().ReverseMap();

            // add for product also

            //CreateMap<Product, ProductModel>().ReverseMap();
        }
    }
}
