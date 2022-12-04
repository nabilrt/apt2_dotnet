using AutoMapper;
using BankApplicationBussinessLogicLayer.DTOs;
using BankApplicationDataAccessLayer.DB.Models;
using BankApplicationDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationBussinessLogicLayer.Services
{
    public class AccountServices
    {
        public static List<AccountModel> getAllAccounts()
        {
            var accounts = DataAccessFactory.AccountDataAccess().getALL();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Account, AccountModel>());
            var mapper = new Mapper(config);
            var accountsList = mapper.Map<List<AccountModel>>(accounts);
            return accountsList;
        }

        public static AccountModel GetAccount(int id)
        {
            var account = DataAccessFactory.AccountDataAccess().get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Account, AccountModel>());
            var mapper = new Mapper(config);
            var acc = mapper.Map<AccountModel>(account);
            return acc;

        }

        public static bool AddAccount(AccountModel acc)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<AccountModel, Account>());
            var mapper = new Mapper(config);
            var account = mapper.Map<Customer>(acc);

            if (DataAccessFactory.CustomerDataAccess().Add(account))
            {
                return true;

            }
            return false;
        }
    }
}
