using EcommerceDataAccessLayer.DB;
using EcommerceDataAccessLayer.Interfaces;
using EcommerceDataAccessLayer.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDataAccessLayer
{
    public class DataAccessFactory
    {
        public static IOperations<Category,int,bool> CategoryDataAccess()
        {
            return new CategoryOperations();
        }

        public static IOperations<Product,int,bool> ProductDataAccess()
        {
            return new ProductOperations();
        }

        public static IOperations<User,int,bool> UserDataAccess()
        {
            return new UserOperations();
        }

        public static IOperations<Admin,int,bool> AdminDataAccess()
        {
            return new AdminOperations();
        }

        public static IAuthentication<User> UserAuthenticate()
        {
            return new UserOperations();
        }

        public static IAuthentication<Admin> AdminAuthentication()
        {
            return new AdminOperations();
        }
    }
}
