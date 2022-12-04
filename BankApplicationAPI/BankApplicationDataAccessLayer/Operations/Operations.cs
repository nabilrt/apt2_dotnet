using BankApplicationDataAccessLayer.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationDataAccessLayer.Operations
{
    internal class Operations
    {
        protected CustomerContext db;

        public Operations()
        {
            db = new CustomerContext();
        }
    }
}
