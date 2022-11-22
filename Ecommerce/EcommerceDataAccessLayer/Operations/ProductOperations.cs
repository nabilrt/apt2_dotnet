using EcommerceDataAccessLayer.DB;
using System.Collections.Generic;
using System.Linq;

namespace EcommerceDataAccessLayer.Operations
{
    internal class ProductOperations : IOperations<Product, int, bool>
    {
        EcommerceDBEntities ecommerceDB = new EcommerceDBEntities();
        public bool add(Product cls)
        {
            ecommerceDB.Products.Add(cls);

            if (ecommerceDB.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }

        public bool delete(int id)
        {
            var product=get(id);

            ecommerceDB.Products.Remove(product);

            if (ecommerceDB.SaveChanges() > 0)
            {
                return true;    
            }
            return false;
        }

        public Product get(int id)
        {
            var product= ecommerceDB.Products.Find(id);

            return product;
        }

        public List<Product> getAll()
        {
            var products= ecommerceDB.Products.ToList();    

            return products;
        }

        public bool Update(Product cls)
        {
            var product = get(cls.Id);

            product.Id= cls.Id;
            product.Name= cls.Name;
            product.Category= cls.Category;
            product.Quantity= cls.Quantity;
            product.CategoryId= cls.CategoryId;

            if (ecommerceDB.SaveChanges() > 0)
            {
                return true;
            }

            return false;
        }
    }
}
