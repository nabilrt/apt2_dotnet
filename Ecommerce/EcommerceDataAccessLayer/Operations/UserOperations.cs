using EcommerceDataAccessLayer.DB;
using EcommerceDataAccessLayer.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceDataAccessLayer.Operations
{

    internal class UserOperations : IOperations<User, int, bool>, IAuthentication<User>
    {
        EcommerceDBEntities ecommerceDB = new EcommerceDBEntities();
        public bool add(User cls)
        {
            ecommerceDB.Users.Add(cls);

            if (ecommerceDB.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }

        public User Authenticate(string username, string password)
        {
            var user=(from u in ecommerceDB.Users where u.Username == username && u.Password==password select u).SingleOrDefault();

            if (user != null)
            {
                return user;
            }

            return null;
        }

        public bool delete(int id)
        {
            var user=get(id);

            ecommerceDB.Users.Remove(user);

            if (ecommerceDB.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }

        public User get(int id)
        {
            var user= ecommerceDB.Users.Find(id);

            return user;
        }

        public List<User> getAll()
        {
            var users=ecommerceDB.Users.ToList();   

            return users;
        }

        public bool Update(User cls)
        {
            var user = get(cls.Id);

            user.Id= cls.Id;    
            user.Name= cls.Name;
            user.Username= cls.Username;
            user.Password=cls.Password;

            if(ecommerceDB.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }
    }
}
