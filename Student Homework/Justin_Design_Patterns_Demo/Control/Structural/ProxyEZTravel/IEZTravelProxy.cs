using hsdc.dpt.Control.DTO.Structual.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.ProxyEZTravel
{
    interface IEZTravelProxy
    {
        List<HotelsInfo> GetHotelsInfo(HotelsInfo info);
        string GetHotelRoomsUrl(HotelsInfo info);
    }
}
