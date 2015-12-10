using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Structual.Proxy
{
    class EZTravelDto
    {

    }

    public class HotelsInfo
    {
        public string OriginUrl { get; set; }
        public string HotelsName { get; set; }
        public string Address { get; set; }
        public string NotCheckIn { get; set; }
        public string Quantity { get; set; }
        public string GuestsRooms { get; set; } 
        public int Star { get; set; }
        public decimal Price { get; set; }
        public string PropertyType { get; set;}
        public int GuestRating { get; set; }
    }
}
