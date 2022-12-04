using BankApplicationDataAccessLayer.DB.Models;
using BankApplicationDataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationDataAccessLayer.Operations
{
    internal class AccountOperations : Operations, IOperations<Account, int, bool>
    {
        public bool Add(Account cls)
        {
            db.Accounts.Add(cls);

            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            db.Accounts.Remove(get(id));

            return db.SaveChanges()>0;
        }

        public Account get(int id)
        {
            return db.Accounts.Find(id);
        }

        public List<Account> getALL()
        {
           return db.Accounts.ToList();
        }

        public bool Update(Account cls)
        {
            var account = get(cls.Id);

            account.InterestRate = cls.InterestRate;
            account.Balance = cls.Balance;  
            account.AccountType = cls.AccountType;
            account.CustomerId = cls.CustomerId;

            return db.SaveChanges() > 0;
        }
    }
}
