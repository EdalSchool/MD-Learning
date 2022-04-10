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
    public class BsCategory
    {
        public static List<Category> CategoryList()
        {
            using (var db = new BlazorAppContext())
            {
                return db.Categories.ToList();
            }
        }

        public static Category CategoryById(string Id)
        {
            using (var db = new BlazorAppContext())
            {
                return db.Categories.ToList().LastOrDefault(c => c.CategoryId == Id);
            }
        }

        public static void CategoryCreation(Category oCategory)
        {
            using (var db = new BlazorAppContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public static void CategoryUpdate (Category oCategory)
        {
            using (var db = new BlazorAppContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }

        public static void CategoryDeletion (Category oCategory)
        {
            using (var db = new BlazorAppContext())
            {
                db.Categories.Remove(oCategory);
                db.SaveChanges();
            }
        }
    }
}
