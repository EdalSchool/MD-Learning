﻿using DataAccess;
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

        public static bool IsProdctInWarehouse(string idStorage)
        {
            using (var db = new BlazorAppContext())
            {
                var product = db.Storages.ToList().Where(s => s.StorageId == idStorage);

                return product.Any();
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
