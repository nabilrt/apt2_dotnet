using BankApplicationDataAccessLayer.DB.Models;
using BankApplicationDataAccessLayer.Interfaces;
using BankApplicationDataAccessLayer.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationDataAccessLayer
{
    public class DataAccessFactory
    {
        public static IOperations<Customer, int, bool> CustomerDataAccess() {

            return new CustomerOperations();
        }

        public static IOperations<Account, int, bool> AccountDataAccess() { return new AccountOperations(); }
    }
}
