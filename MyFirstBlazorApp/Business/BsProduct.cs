using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BsProduct
    {
        public static List<Product> ProductList()
        {
            using (var db = new BlazorAppContext())
            {
                return db.Products.ToList();
            }
        }

        public static void ProductCreation(Product oProduct)
        {
            using (var db = new BlazorAppContext())    
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }

        public static void ProductUpdate(Product oProduct)
        {
            using (var db = new BlazorAppContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }
    }
}
