using hsdc.dpt.Control.DTO.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.Singleton
{
    public class IDGeneratorSingleton
    {
        private static volatile IDGeneratorSingleton instance;
        private static object syncRoot = new Object();

        private IDGeneratorSingleton() 
        {
            this.IdCounter = new Dictionary<Form, int>();
        }

        public static IDGeneratorSingleton Instance
        {
            get 
            {
                if (instance == null) 
                {
                lock (syncRoot) 
                {
                    if (instance == null)
                        instance = new IDGeneratorSingleton();
                }
                }

                return instance;
            }
        }

        private Dictionary<Form, Int32> IdCounter;

        public string GetNextID(string formType, DateTime formDate)
        {
            int currentId = 0;
            Form key = new Form() { FormType = formType, FormDateStr = formDate.ToString("yyyyMMdd") };
            if (!IdCounter.TryGetValue(key, out currentId))
            {
                IdCounter.Add(key, currentId);
            }
            currentId += 1;
            IdCounter[key] = currentId;
            return key.FormDateStr + currentId.ToString("D4");
        }
    }
}
