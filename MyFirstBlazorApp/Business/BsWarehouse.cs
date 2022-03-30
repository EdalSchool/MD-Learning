using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BsWarehouse
    {
        public static List<Warehouse> WarehouseList()
        {
            using (var db = new BlazorAppContext())
            {
                return db.Warehouses.ToList();
            }
        }

        public static void WarehouseCreation(Warehouse oWarehouse)
        {
            using (var db = new BlazorAppContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }

        public static void WarehouseUpdate(Warehouse oWarehouse)
        {
            using (var db = new BlazorAppContext())
            {
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
    }
}
