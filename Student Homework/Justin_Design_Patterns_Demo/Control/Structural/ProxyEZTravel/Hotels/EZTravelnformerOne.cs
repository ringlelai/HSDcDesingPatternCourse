using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Structual.Proxy;

namespace hsdc.dpt.Control.Structural.ProxyEZTravel
{
    class EZTravelnformerOne : IEZTravelProxy

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
                OriginUrl = "http://www.hotelOne/",
                HotelsName = "晶華誠",
                Address = "台北市大同區",
                NotCheckIn = "Y",
                Quantity = "1",
                GuestsRooms = "二房",
                Star = 1,
                Price = 1000,
                PropertyType = "酒店",
                GuestRating = 9
            });
            hotelsinfoList.Add(new HotelsInfo
            {
                OriginUrl = "http://www.hotelOne/",
                HotelsName = "花蓮美倫大飯店",
                Address = "花蓮縣",
                NotCheckIn = "Y",
                Quantity = "1",
                GuestsRooms = "二房",
                Star = 1,
                Price = 1000,
                PropertyType = "酒店",
                GuestRating = 9
            });

            return hotelsinfoList;
        }
    }
}
