using EcommerceDataAccessLayer.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDataAccessLayer.Interfaces
{
    public interface IAuthentication<CLASS>
    {
        CLASS Authenticate(string username, string password);
      //  Admin Authentication(string username, string password);

    }
}
