using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationBussinessLogicLayer.DTOs
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
