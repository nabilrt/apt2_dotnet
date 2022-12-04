using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationBussinessLogicLayer.DTOs
{
    public class AccountModel
    {
        public int Id { get; set; }

        public double Balance { get; set; }

        public string AccountType { get; set; }

        public float? InterestRate { get; set; }

        
        public int CustomerId { get; set; }
    }
}
