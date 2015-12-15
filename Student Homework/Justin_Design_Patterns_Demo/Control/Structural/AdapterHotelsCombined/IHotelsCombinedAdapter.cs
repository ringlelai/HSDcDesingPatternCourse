using hsdc.dpt.Control.DTO.Structual.Adapter;
using hsdc.dpt.Control.DTO.Structual.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.AdapterHotelsCombined
{
    interface IHotelsCombinedAdapter
    {
        List<TravelSitesInfo> GetHotelsInfo(TravelSitesInfo info);
        string GetHotelRoomsUrl(TravelSitesInfo info);
    }
}
