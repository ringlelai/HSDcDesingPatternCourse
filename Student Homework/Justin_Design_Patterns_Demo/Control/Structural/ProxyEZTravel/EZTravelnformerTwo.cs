using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Structual.Proxy;

namespace hsdc.dpt.Control.Structural.ProxyEZTravel
{
    class EZTravelnformerTwo : IEZTravelProxy

    {
        public string GetHotelRoomsUrl(HotelsInfo info)
        {
            throw new NotImplementedException();
        }

        public List<HotelsInfo> GetHotelsInfo(HotelsInfo info)
        {
            var hotelsinfoList = new List<HotelsInfo>();
            hotelsinfoList.Add(new HotelsInfo
            {
                OriginUrl = "http://www.hotelTwo/",
                HotelsName = "台中雲品飯店",
                Address = "台中市大同區",
                NotCheckIn = "Y",
                Quantity = "1",
                GuestsRooms = "二大",
                Star = 1,
                Price = 1000,
                PropertyType = "飯店",
                GuestRating = 9
            });
            hotelsinfoList.Add(new HotelsInfo
            {
                OriginUrl = "http://www.hotelTwo/",
                HotelsName = "台南星光大旅社",
                Address = "台南市",
                NotCheckIn = "Y",
                Quantity = "1",
                GuestsRooms = "二大一小",
                Star = 1,
                Price = 1000,
                PropertyType = "旅社",
                GuestRating = 9
            });

            return hotelsinfoList;
        }
    }
}
