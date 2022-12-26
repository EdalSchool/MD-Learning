using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
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

        public static Product ProductById(string Id)
        {
            using (var db = new BlazorAppContext())
            {
                return db.Products.Include(p => p.Category).ToList().LastOrDefault(p => p.ProductId == Id);
            }
        }

        public static BsResponse ProductCreation(Product oProduct)
        {
            using (var db = new BlazorAppContext())
            {
                if (!db.Products.Any(x => x.ProductId == oProduct.ProductId))
                {
                    db.Products.Add(oProduct);
                    db.SaveChanges();
                    return new BsResponse { IsSuccessfull = true };
                }
                else
                    return new BsResponse { IsSuccessfull = false, ErrorMessage = "Another product already has this Id" };
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

        public static void ProductDeletion(Product oProduct)
        {
            using (var db = new BlazorAppContext())
            {
                db.Products.Remove(oProduct);
                db.SaveChanges();
            }
        }
    }
}
