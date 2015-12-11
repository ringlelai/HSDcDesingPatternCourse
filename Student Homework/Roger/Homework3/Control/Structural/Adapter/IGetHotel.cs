using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hsdc.dpt.Control.DTO.Structual.Adapter;

namespace hsdc.dpt.Control.Structural.Adapter
{
    public interface IGetHotel
    {
        List<Hotel> getHotelList();
    }
}
