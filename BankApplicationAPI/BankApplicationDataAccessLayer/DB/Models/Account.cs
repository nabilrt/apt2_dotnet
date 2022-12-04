using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationDataAccessLayer.DB.Models
{
    public class Account
    {
        [Key]
        
        public int Id { get; set; }

        public double Balance { get; set; }

        public string AccountType { get; set; }

        public float? InterestRate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

       public virtual Customer Customer { get; set; }
    }
}
