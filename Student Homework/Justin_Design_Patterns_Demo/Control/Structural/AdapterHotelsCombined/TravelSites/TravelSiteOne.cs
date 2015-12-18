using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Structual.Proxy;

namespace hsdc.dpt.Control.Structural.AdapterHotelsCombined
{
    public class TravelSitesOne //: IHotelsCombinedAdapter
    {
        public class TravelSitesOneInfo
        {
            public string OriginUrl { get; set; }
            public string HotelsName { get; set; }
            public string Address { get; set; }
            public string NotCheckIn { get; set; }
            public string Quantity { get; set; }
            public string GuestsBig { get; set; }
            public string Guestsmall { get; set; }
            public int Star { get; set; }
            public decimal Price { get; set; }
            public string PropertyType { get; set; }
            public int GuestRating { get; set; }
        }


        public string GetHotelRoomsUrl(TravelSitesOneInfo info)
        {
            throw new NotImplementedException();
        }

        public List<TravelSitesOneInfo> GetHotelsInfo()
        {
            var hotelsinfoList = new List<TravelSitesOneInfo>();
            hotelsinfoList.Add(new TravelSitesOneInfo
            {
                OriginUrl = "http://www.hotelOne/",
                HotelsName = "晶華誠",
                Address = "台北市大同區",
                NotCheckIn = "Y",
                Quantity = "1",
                GuestsBig = "二大",
                Guestsmall = "一小",
                Star = 1,
                Price = 1000,
                PropertyType = "酒店",
                GuestRating = 9
            });
            hotelsinfoList.Add(new TravelSitesOneInfo
            {
                OriginUrl = "http://www.hotelOne/",
                HotelsName = "花蓮美倫大飯店",
                Address = "花蓮縣",
                NotCheckIn = "Y",
                Quantity = "1",
                GuestsBig = "二大",
                Guestsmall = "",
                Star = 1,
                Price = 1000,
                PropertyType = "酒店",
                GuestRating = 9
            });

            return hotelsinfoList;
        }
    }
}
