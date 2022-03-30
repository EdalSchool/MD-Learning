using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BsInOut
    {
        public static List<InOut> InOutList()
        {
            using (var db = new BlazorAppContext())
            {
                return db.InOuts.ToList();
            }
        }

        public static void InOutsCreation(InOut oInOut)
        {
            using (var db = new BlazorAppContext())
            {
                db.InOuts.Add(oInOut);
                db.SaveChanges();
            }
        }

        public static void CategoryUpdate(InOut oInOut)
        {
            using (var db = new BlazorAppContext())
            {
                db.InOuts.Update(oInOut);
                db.SaveChanges();
            }
        }
    }
}
