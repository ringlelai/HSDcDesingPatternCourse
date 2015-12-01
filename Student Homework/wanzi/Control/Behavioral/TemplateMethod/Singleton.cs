using hsdc.dpt.Control.DTO.Behavioral.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.TemplateMethod.Singleton
{
    internal class Db
    {
        private static volatile Db instance;
        private static object syncRoot = new Object();
        private List<Policy> db;

        private Db()
        {
            db = new List<Policy>();
            db.Add(new Policy() { PolicyNumber = "01010001", PolicyName = "健康險1", PolicyOwnerName = "Ringle", PolicyInsuredName = "Ringle", PolicyType = PolicyType.Normal });
            db.Add(new Policy() { PolicyNumber = "01010002", PolicyName = "健康險2", PolicyOwnerName = "Ringle", PolicyInsuredName = "Ringle", PolicyType = PolicyType.HasClaimed });
            db.Add(new Policy() { PolicyNumber = "01010003", PolicyName = "壽險1", PolicyOwnerName = "Ringle", PolicyInsuredName = "Test", PolicyType = PolicyType.InAprrove });
            db.Add(new Policy() { PolicyNumber = "01010004", PolicyName = "壽險2", PolicyOwnerName = "Ringle", PolicyInsuredName = "Ajewl", PolicyType = PolicyType.Normal });
            db.Add(new Policy() { PolicyNumber = "01010005", PolicyName = "壽險3", PolicyOwnerName = "Ringle", PolicyInsuredName = "Ringle", PolicyType = PolicyType.InAprrove });
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

        internal List<Policy> GetPolicies()
        {
            return this.db;
        }
    }
}
