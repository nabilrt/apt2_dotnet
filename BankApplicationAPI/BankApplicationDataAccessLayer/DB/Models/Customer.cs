using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationDataAccessLayer.DB.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }   
        public virtual List<Account> Accounts { get; set; }

        public Customer() { 
        
            Accounts = new List<Account>();
        }




    }
}
