using BankApplicationDataAccessLayer.DB.Models;
using BankApplicationDataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationDataAccessLayer.Operations
{
    internal class CustomerOperations : Operations,IOperations<Customer, int, bool>
    {
        public bool Add(Customer cls)
        {
            db.Customers.Add(cls);

            if (db.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            var customer= db.Customers.Find(id);

            db.Customers.Remove(customer);

            return db.SaveChanges()>0;
        }

        public Customer get(int id)
        {
            var customer = db.Customers.Find(id);

            return customer;

        }

        public List<Customer> getALL()
        {
            return db.Customers.ToList();
        }

        public bool Update(Customer cls)
        {
            var customer = get(cls.Id);

            customer.Name = cls.Name;
            customer.Username = cls.Username;   
            customer.Password = cls.Password;
            customer.DOB=cls.DOB;

            return db.SaveChanges() > 0;
        }
    }
}
