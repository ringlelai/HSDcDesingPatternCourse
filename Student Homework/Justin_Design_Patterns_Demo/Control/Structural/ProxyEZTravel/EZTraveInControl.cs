using hsdc.dpt.Control.DTO.Structual.Proxy;
using hsdc.dpt.Control.Structural.Proxyhotelscombined;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.ProxyEZTravel
{
    public class EZTraveInControl
    {
        IEZTravelProxy proxy = new EZTravelProxy();
        public List<HotelsInfo> GetHotelsInfo(HotelsInfo info)
        {
            return proxy.GetHotelsInfo(info);
        }
    }
}
