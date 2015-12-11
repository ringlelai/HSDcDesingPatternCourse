using hsdc.dpt.Control.DTO.Behavioral.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Mediator.Singleton
{
    internal class Db
    {
        private static volatile Db instance;
        private static object syncRoot = new Object();
        private List<Stocking> db;

        private Db()
        {
            db = new List<Stocking>();
            db.Add(new Stocking() { Product = new Product() { ProductName = "Ringle's Book" }, Quantity = 0 });
            db.Add(new Stocking() { Product = new Product() { ProductName = "Kenming's Book" }, Quantity = 100 });
            db.Add(new Stocking() { Product = new Product() { ProductName = "GoF" }, Quantity = 2 });
        }

        internal static Db Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Db();
                    }
                }

                return instance;
            }
        }

        internal List<Stocking> GetStocking()
        {
            return this.db;
        }
    }
}
