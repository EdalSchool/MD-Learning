using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BsStorage
    {
        public static List<Storage> StorageList()
        {
            using (var db = new BlazorAppContext())
            {
                return db.Storages.ToList();
            }
        }

        public static void StorageCreation(Storage oStorage)
        {
            using (var db = new BlazorAppContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        public static void StorageUpdate(Storage oStorage)
        {
            using (var db = new BlazorAppContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }
    }
}
