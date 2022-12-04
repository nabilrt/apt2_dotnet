using BankApplicationDataAccessLayer.DB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationDataAccessLayer.DB
{
    public class CustomerContext:DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Customer> Customers { get; set; }
    }
}
