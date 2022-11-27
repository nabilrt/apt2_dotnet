using AutoMapper;
using EcommerceBussinessLogicLayer.DTO;
using EcommerceDataAccessLayer;
using EcommerceDataAccessLayer.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceBussinessLogicLayer.Services
{
    public class CategoryServices
    {
        public static List<CategoryModel> getAllCategories()
        {
            var categories = DataAccessFactory.CategoryDataAccess().getAll();
            var config=new MapperConfiguration(cfg=>cfg.CreateMap<Category,CategoryModel>());
            var mapper=new Mapper(config);
            var categoryList=mapper.Map<List<CategoryModel>>(categories);

            return categoryList;
        }
    }
}
