using hsdc.dpt.Control.Structural.Adapter.ExternalSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Adapter.ExternalSystem
{
    // Assume xml format is used by Agoda.com
    public class AgodaSystem
    {
        public string getHotelsXml()
        {
            return "<hotels>"
                + "<hotel>"
                + "	   <city>Sapporo</city>"
                + "    <name>JR INN</name>"
                + "    <price>1500</price>"
                + "	   <roomType>1</roomType>"
                + "</hotel>"
                + "<hotel>"
                + "	   <city>Taipei</city>"
                + "	   <name>Caesar Park Hotel</name>"
                + "	   <price>2000</price>"
                + "	   <roomType>2</roomType>"
                + "	</hotel>"
                + "	<hotel>"
                + "	   <city>Taipei</city>"
                + "	   <name>The Okura Prestige Taipei</name>"
                + "	   <price>3000</price>"
                + "	   <roomType>4</roomType>"
                + "</hotel>"
                + "</hotels>";
        }
    }

    // Assume api is provided by Booking.com
    public class BookingSystem
    {
        public List<BookingHotel> getBookingHotelList()
        {
            List<BookingHotel> result = new List<BookingHotel>();
            result.Add(new BookingHotel { country = "Japan", city = "Sapporo", name = "JR INN", price = "2000", roomSize = "BIG" });
            result.Add(new BookingHotel { country = "Japan", city = "Sapporo", name = "Prince Hotel", price = "1600", roomSize = "MEDIUM" });
            result.Add(new BookingHotel { country = "Taiwan", city = "Taipei", name = "The Landis Taipei", price = "1700", roomSize = "SMALL" });
            return result;
        }
    }
}
