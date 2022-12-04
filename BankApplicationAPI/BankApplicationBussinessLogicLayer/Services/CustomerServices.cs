using AutoMapper;
using BankApplicationBussinessLogicLayer.DTOs;
using BankApplicationDataAccessLayer;
using BankApplicationDataAccessLayer.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationBussinessLogicLayer.Services
{
    public class CustomerServices
    {
        public static List<CustomerModel> getAllCustomers()
        {
            var customers = DataAccessFactory.CustomerDataAccess().getALL();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerModel>());
            var mapper = new Mapper(config);
            var customersList = mapper.Map<List<CustomerModel>>(customers);
            return customersList;
        }

        public static CustomerModel GetCustomer(int id)
        {
            var customer = DataAccessFactory.CustomerDataAccess().get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Customer, CustomerModel>());
            var mapper = new Mapper(config);
            var cust = mapper.Map<CustomerModel>(customer);
            return cust;

        }

        public static bool AddCustomer(CustomerModel cus)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<CustomerModel, Customer>());
            var mapper = new Mapper(config);
            var cust = mapper.Map<Customer>(cus);

            if (DataAccessFactory.CustomerDataAccess().Add(cust))
            {
                return true;

            }
            return false;
        }
    }
}
