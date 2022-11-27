using EcommerceBussinessLogicLayer.DTO;
using EcommerceBussinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;


namespace Ecommerce.Controllers
{
    public class ProductController:ApiController 
    {
        [EnableCors("*","*","*")]
        [Route("api/products")]
        [HttpGet]

        public HttpResponseMessage Get()
        {
            var data=ProductServices.getAllProducts();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [EnableCors("*", "*", "*")]
        [Route("api/products/{id}")]
        [HttpGet]

        public HttpResponseMessage getAProduct(int id)
        {
            var data = ProductServices.GetProduct(id);
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }

        [EnableCors("*", "*", "*")]
        [Route("api/product/add")]
        [HttpPost]

        public HttpResponseMessage addProduct(ProductModel product)
        {
            var data = ProductServices.AddProduct(product);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [EnableCors("*","*","*")]
        [Route("api/product/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage deleteProduct(int id)
        {
            var data=ProductServices.RemoveProduct(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [EnableCors("*", "*", "*")]
        [Route("api/product/edit")]
        [HttpPost]
        public HttpResponseMessage editProduct(ProductModel product)
        {
            var data = ProductServices.updateProduct(product);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}