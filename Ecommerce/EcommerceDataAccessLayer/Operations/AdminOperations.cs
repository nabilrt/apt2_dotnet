using EcommerceDataAccessLayer.DB;
using EcommerceDataAccessLayer.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;

namespace EcommerceDataAccessLayer.Operations
{
    internal class AdminOperations : IOperations<Admin, int, bool>, IAuthentication<Admin>
    {
        EcommerceDBEntities db = new EcommerceDBEntities();
        public bool add(Admin cls)
        {
            throw new NotImplementedException();
        }

        public Admin Authenticate(string username, string password)
        {
           // var db=new EcommerceDBEntities();
            var admin = (from r in db.Admins where r.Username==username && r.Password==password select r).FirstOrDefault();

            return admin != null ? admin : null;
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public Admin get(int id)
        {
            var admin=db.Admins.Find(id);

            return admin;
        }

        public List<Admin> getAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Admin cls)
        {
            var admin = get(cls.Id);

            admin.Id=cls.Id;    
            admin.Username=cls.Username;
            admin.Password=cls.Password;

            if (db.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }
    }
}
