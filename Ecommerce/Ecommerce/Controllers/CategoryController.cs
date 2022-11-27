using EcommerceBussinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Ecommerce.Controllers
{
    public class CategoryController : ApiController
    {
        [EnableCors("*", "*", "*")]
        [Route("api/categories")]
        [HttpGet]

        public HttpResponseMessage getAllCategories()
        {
            var data=CategoryServices.getAllCategories();

            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

    }
}
