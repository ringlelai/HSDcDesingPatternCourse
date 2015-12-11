using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Adapter
{
    class AdapterManager
    {
        public List<IGetHotel> getAllAdapter()
        {
            List<IGetHotel> adapterList = new List<IGetHotel>();
            adapterList.Add(new AgodaAdapter());
            adapterList.Add(new BookingAdapter());
            return adapterList;
        }
    }
}
