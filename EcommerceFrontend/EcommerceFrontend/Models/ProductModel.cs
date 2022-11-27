using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceFrontend.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}