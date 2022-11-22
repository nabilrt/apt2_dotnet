using EcommerceDataAccessLayer.DB;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceDataAccessLayer.Operations
{
    internal class CategoryOperations : IOperations<Category, int, bool>
    {

        EcommerceDBEntities ecommerceDB=new EcommerceDBEntities();

        public bool add(Category cls)
        {
            ecommerceDB.Categories.Add(cls);

            if (ecommerceDB.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool delete(int id)
        {
            var category=ecommerceDB.Categories.Find(id);

            ecommerceDB.Categories.Remove(category);

            if (ecommerceDB.SaveChanges() > 0)
            {
                return true;
            }
            return false;

        }

        public Category get(int id)
        {
            var category = ecommerceDB.Categories.Find(id);

            return category;
        }

        public List<Category> getAll()
        {
            var categories=ecommerceDB.Categories.ToList();

            return categories;
        }

        public bool Update(Category cls)
        {
            var category = get(cls.Id);

            category.Id=cls.Id;
            category.Name=cls.Name;

            if (ecommerceDB.SaveChanges() > 0)
            {
                return true;
            }
            return false;


        }
    }
}
