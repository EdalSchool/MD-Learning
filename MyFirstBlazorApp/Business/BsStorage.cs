using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

        /// <summary>
        /// Checks if a product has been in a warehouse
        /// </summary>
        /// <param name="idStorage"></param>
        /// <returns></returns>
        public static bool IsProductInWarehouse(string idStorage)
        {
            using (var db = new BlazorAppContext())
            {
                return db.Storages.Include(s => s.Warehouse).Include(s => s.Product).Any(s => s.StorageId == idStorage);
            }
        }

        /// <summary>
        /// Checks if a product has been in a warehouse
        /// </summary>
        /// <param name="idProduct">Specifies the id for the product to be searched</param>
        /// <param name="idWarehouse">Specifies the id for the warehouse to be searched</param>
        /// <returns></returns>
        public static bool IsProductInWarehouse(string idProduct, string idWarehouse)
        {
            using (var db = new BlazorAppContext())
            {
                return db.Storages.Any(s => s.ProductId == idProduct && s.WarehouseId == idWarehouse);
            }
        }

        public static List<Storage> StorageByWarehouse(string idWarehouse)
        {
            using (var db = new BlazorAppContext())
            {
                return db.Storages
                    .Include(s => s.Product)
                    .Include(s => s.Warehouse)
                    .Where(s => s.WarehouseId == idWarehouse)
                    .ToList();
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
