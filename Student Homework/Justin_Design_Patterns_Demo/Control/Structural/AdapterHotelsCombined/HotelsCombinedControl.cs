using hsdc.dpt.Control.DTO.Structual.Adapter;
using hsdc.dpt.Control.DTO.Structual.Proxy;
using hsdc.dpt.Control.Structural.Proxyhotelscombined;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.AdapterHotelsCombined
{
    public class HotelsCombinedControl
    {
        IHotelsCombinedAdapter adapter = new HotelsCombinedAdapter();
        public List<TravelSitesInfo> GetHotelsInfo(TravelSitesInfo info)
        {
            return adapter.GetHotelsInfo(info);
        }
    }
}
