using BankApplicationBussinessLogicLayer.DTOs;
using BankApplicationBussinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Http;

namespace BankApplicationAPI.Controllers
{
    public class CustomerController:ApiController
    {
        [EnableCors("*", "*", "*")]
        [Route("api/customers")]
        [HttpGet]

        public HttpResponseMessage Get()
        {
            var data = CustomerServices.getAllCustomers();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [EnableCors("*", "*", "*")]
        [Route("api/customer/{id}")]
        [HttpGet]

        public HttpResponseMessage getACustomer(int id)
        {
            var data = CustomerServices.GetCustomer(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [EnableCors("*", "*", "*")]
        [Route("api/customer/add")]
        [HttpPost]

        public HttpResponseMessage addCustomer(CustomerModel customer)
        {
            var data = CustomerServices.AddCustomer(customer);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}