using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using BankApplicationBussinessLogicLayer.Services;
using BankApplicationBussinessLogicLayer.DTOs;

namespace BankApplicationAPI.Controllers
{
    public class AccountController:ApiController 
    {
        [EnableCors("*", "*", "*")]
        [Route("api/accounts")]
        [HttpGet]

        public HttpResponseMessage Get()
        {
            var data =AccountServices.getAllAccounts();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [EnableCors("*", "*", "*")]
        [Route("api/account/{id}")]
        [HttpGet]

        public HttpResponseMessage getAnAccount(int id)
        {
            var data = AccountServices.GetAccount(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [EnableCors("*", "*", "*")]
        [Route("api/account/add")]
        [HttpPost]

        public HttpResponseMessage addAccount(AccountModel account)
        {
            var data = AccountServices.AddAccount(account);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}