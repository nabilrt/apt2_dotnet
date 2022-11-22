using EcommerceBussinessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceDataAccessLayer;
using AutoMapper;
using EcommerceDataAccessLayer.DB;

namespace EcommerceBussinessLogicLayer.Services
{
    public class ProductServices
    {
       // EcommerceDBEntites 
/*        public ProductServices() { 
        }*/

        public static List<ProductModel> getAllProducts()
        {
            var products = DataAccessFactory.ProductDataAccess().getAll();
            var config=new MapperConfiguration(cfg=>cfg.CreateMap<Product,ProductModel>());
            var mapper = new Mapper(config);
            var productsList = mapper.Map<List<ProductModel>>(products);
            return productsList;
        }

        public static ProductModel GetProduct(int id)
        {
            var product=DataAccessFactory.ProductDataAccess().get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product, ProductModel>());
            var mapper = new Mapper(config);
            var productItem=mapper.Map<ProductModel>(product);
            return productItem;

        }

        public static bool AddProduct(ProductModel product)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductModel, Product>());
            var mapper = new Mapper(config);
            var productItem = mapper.Map<Product>(product);

            if (DataAccessFactory.ProductDataAccess().add(productItem))
            {
                return true;

            }
            return false;
        }

        public static bool RemoveProduct(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductModel, Product>());
            var mapper = new Mapper(config);
            var product=new ProductModel();
           /* product.Id = id;
            var productItem = mapper.Map<Product>(product);*/
            if (DataAccessFactory.ProductDataAccess().delete(id))
            {
                return true;
            }

            return false;

        }

        public static bool updateProduct(ProductModel product)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ProductModel, Product>());
            var mapper = new Mapper(config);
            var productItem = mapper.Map<Product>(product);

            if (DataAccessFactory.ProductDataAccess().Update(productItem))
            {
                return true;
            }

            return false;
        }
    }
}
