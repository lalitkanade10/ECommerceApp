using AutoMapper;
using ECommerce.Data.Entiry.Masters;
using ECommerce.Models.Models.Masters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Repository.Helper
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            CreateMap<DepartmentMaster, DepartmentMasterModels>().ReverseMap();
            CreateMap<CategoryMaster, CategoryMasterModels>().ReverseMap();
            CreateMap<ItemMaster, ItemMasterModels>().ReverseMap();
            CreateMap<ItemsDiscountDetails, ItemsDiscountDetailsModels>().ReverseMap();
            CreateMap<ItemsImagesDetails, ItemsImagesDetailsModels>().ReverseMap();
            CreateMap<UnitMaster, UnitMasterModels>().ReverseMap();
        }
    }
}
