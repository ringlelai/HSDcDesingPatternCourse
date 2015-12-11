using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hsdc.dpt.Control.DTO.Structual.Adapter;

namespace hsdc.dpt.Control.Structural.Adapter
{
    public class ListHotelsUco
    {
        private AdapterManager adapterManager;
        public ListHotelsUco()
        {
            this.adapterManager = new AdapterManager();
        }

        public List<Hotel> getAllHotelList()
        {
            List<IGetHotel> adapterList = this.adapterManager.getAllAdapter();
            List<Hotel> hotelList = new List<Hotel>();
            foreach (IGetHotel adapter in adapterList)
            {
                hotelList.AddRange(adapter.getHotelList());
            }
            return hotelList.OrderBy(x=>x.name).ToList();
        }
    }
}
