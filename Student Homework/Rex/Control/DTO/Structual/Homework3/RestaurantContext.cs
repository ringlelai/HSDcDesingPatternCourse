using System.Collections.Generic;

namespace hsdc.dpt.Control.DTO.Structual.Homework3
{
    public class RestaurantContext
    {
        private static volatile RestaurantContext _instance;
        private static readonly object SyncRoot = new object();

        internal static RestaurantContext Instance
        {
            get
            {
                if (_instance != null) return _instance;

                lock (SyncRoot)
                {
                    if (_instance == null)
                        _instance = new RestaurantContext();
                }

                return _instance;
            }
        }

        private RestaurantContext()
        {
            Restaurants = new List<Restaurant>
            {
                new Restaurant {Name = "飯店01號",Descript = "描述一下" , Price =1100 },
                new Restaurant {Name = "飯店02號",Descript = "描述一下" , Price =1200 },
                new Restaurant {Name = "飯店03號",Descript = "描述一下" , Price =1300 },
                new Restaurant {Name = "飯店04號",Descript = "描述一下" , Price =1400 },
                new Restaurant {Name = "飯店05號",Descript = "描述一下" , Price =1500 },
                new Restaurant {Name = "飯店06號",Descript = "描述一下" , Price =1600 },
                new Restaurant {Name = "飯店07號",Descript = "描述一下" , Price =1700 },
                new Restaurant {Name = "飯店08號",Descript = "描述一下" , Price =1800 },
                new Restaurant {Name = "飯店09號",Descript = "描述一下" , Price =1900 },
                new Restaurant {Name = "飯店10號",Descript = "描述一下" , Price =2000 },
                new Restaurant {Name = "飯店11號",Descript = "描述一下" , Price =2100 },
                new Restaurant {Name = "飯店12號",Descript = "描述一下" , Price =2200 },
            };
        }

        public List<Restaurant> Restaurants { get; set; }
    }
}