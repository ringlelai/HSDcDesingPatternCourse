using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Structual.Proxy;

namespace hsdc.dpt.Control.Structural.AdapterHotelsCombined
{
    public class TravelSiteTwo
    {
        public class TravelSitesTwoInfo
        {
            public string　Url { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string NotCheckIn { get; set; }
            public string Quantity { get; set; }
            public string Guests { get; set; }
            public int Star { get; set; }
            public decimal Price { get; set; }
        }
        public string GetHotelRoomsUrl(TravelSitesTwoInfo info)
        {
            throw new NotImplementedException();
        }

        public List<TravelSitesTwoInfo> GetHotelsInfo()
        {
            var hotelsinfoList = new List<TravelSitesTwoInfo>();
            hotelsinfoList.Add(new TravelSitesTwoInfo
            {
                Url = "http://www.hotelTwo/",
                Name = "台中雲品飯店",
                Address = "台中市大同區",
                NotCheckIn = "Y",
                Quantity = "1",
                Guests = "二大",
                Star = 1,
                Price = 1000
            });
            hotelsinfoList.Add(new TravelSitesTwoInfo
            {
                Url = "http://www.hotelTwo/",
                Name = "台南星光大旅社",
                Address = "台南市",
                NotCheckIn = "Y",
                Quantity = "1",
                Guests = "二大一小",
                Star = 1,
                Price = 1000
            });

            return hotelsinfoList;
        }
    }
}
