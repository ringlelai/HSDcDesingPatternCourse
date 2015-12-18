using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Structual.Proxy;
using hsdc.dpt.Control.Structural.AdapterHotelsCombined;
using hsdc.dpt.Control.DTO.Structual.Adapter;

namespace hsdc.dpt.Control.Structural.AdapterHotelsCombined
{
    public class HotelsCombinedAdapter : IHotelsCombinedAdapter
    {
        TravelSitesOne hc1 = new TravelSitesOne();
        TravelSiteTwo hc2 = new TravelSiteTwo();

        public string GetHotelRoomsUrl(TravelSitesInfo info)
        {
            return info.OriginUrl;
        }

        public List<TravelSitesInfo> GetHotelsInfo(TravelSitesInfo info)
        {
            var hotelsInfoList = new List<TravelSitesInfo>();
            var hotelsInfoList1 = hc1.GetHotelsInfo();
            var hotelsInfoList2 = hc2.GetHotelsInfo();
            hotelsInfoList.AddRange(InfoChangeOne(hotelsInfoList1));
            hotelsInfoList.AddRange(InfoChangeTwo(hotelsInfoList2));

            if (!string.IsNullOrEmpty(info.Address) && info.Address.Length > 0)
            {
                hotelsInfoList = hotelsInfoList.Where(a => a.Address.Contains(info.Address)).ToList();
            }
            if (!string.IsNullOrEmpty(info.GuestsRooms))
            {
                hotelsInfoList = hotelsInfoList.Where(a => a.GuestsRooms.Contains(info.GuestsRooms)).ToList();
            }
            return hotelsInfoList;
        }

        public List<TravelSitesInfo> InfoChangeOne(List<TravelSitesOne.TravelSitesOneInfo> info)
        {
            List<TravelSitesInfo> tsinfo = new List<TravelSitesInfo>();
            foreach(var a in info)
            {
                tsinfo.Add(new TravelSitesInfo() {OriginUrl=a.OriginUrl,HotelsName=a.HotelsName,Address=a.Address,NotCheckIn=a.NotCheckIn,Quantity=a.Quantity,GuestsRooms=a.GuestsBig+a.Guestsmall, Star=a.Star,Price=a.Price,PropertyType=a.PropertyType,GuestRating=a.GuestRating });   
            }
            return tsinfo;
        }

        public List<TravelSitesInfo> InfoChangeTwo(List<TravelSiteTwo.TravelSitesTwoInfo> info)
        {
            List<TravelSitesInfo> tsinfo = new List<TravelSitesInfo>();
            foreach (var a in info)
            {
                tsinfo.Add(new TravelSitesInfo() { OriginUrl = a.Url, HotelsName = a.Name, Address = a.Address, NotCheckIn = a.NotCheckIn, Quantity = a.Quantity, GuestsRooms = a.Guests, Star = a.Star, Price = a.Price, PropertyType = "", GuestRating = 0 });
            }
            return tsinfo;
        }
    }
}
