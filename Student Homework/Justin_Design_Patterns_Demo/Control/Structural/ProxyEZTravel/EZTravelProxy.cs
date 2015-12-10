using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hsdc.dpt.Control.DTO.Structual.Proxy;
using hsdc.dpt.Control.Structural.ProxyEZTravel;

namespace hsdc.dpt.Control.Structural.Proxyhotelscombined
{
    public class EZTravelProxy : IEZTravelProxy
    {
        IEZTravelProxy ez1 = new EZTravelnformerOne();
        IEZTravelProxy ez2 = new EZTravelnformerTwo();

        public string GetHotelRoomsUrl(HotelsInfo info)
        {
            return info.OriginUrl;
        }

        public List<HotelsInfo> GetHotelsInfo(HotelsInfo info)
        {
            var hotelsInfoList = new List<HotelsInfo>();
            var hotelsInfoList1 = ez1.GetHotelsInfo(info);
            var hotelsInfoList2 = ez2.GetHotelsInfo(info);
            hotelsInfoList.AddRange(hotelsInfoList1);
            hotelsInfoList.AddRange(hotelsInfoList2);
            if (!string.IsNullOrEmpty(info.Address) && info.Address.Length > 0)
            {
                hotelsInfoList = hotelsInfoList.Where(a => a.Address.Contains(info.Address)).ToList();
            }

            return hotelsInfoList;
        }
    }
}
