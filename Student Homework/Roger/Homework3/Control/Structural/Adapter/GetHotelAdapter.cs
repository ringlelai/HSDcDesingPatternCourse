using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using hsdc.dpt.Control.DTO.Structual.Adapter;
using hsdc.dpt.Control.Structural.Adapter.ExternalSystem;
using System.Xml;
using hsdc.dpt.Control.Structural.Adapter.ExternalSystem.DTO;

namespace hsdc.dpt.Control.Structural.Adapter
{
    // Realize the IGet存貨資訊 Interface
    public class AgodaAdapter : IGetHotel
    {
        private string sourceName = "Agoda.com";

        public List<Hotel> getHotelList()
        {
            AgodaSystem agodaSystem = new AgodaSystem();
            string xml = agodaSystem.getHotelsXml();
            return this.processXml(xml);
        }

        private List<Hotel> processXml(String xml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            System.Diagnostics.Debug.WriteLine(xmlDoc.OuterXml);
            XmlNodeList xnList = xmlDoc.SelectNodes("/hotels/hotel");
            List<Hotel> result = new List<Hotel>();
            foreach (XmlNode xn in xnList)
            {
                string city = xn["city"].InnerText;
                string name = xn["name"].InnerText;
                string price = xn["price"].InnerText;
                string roomType = xn["roomType"].InnerText;
                result.Add(new Hotel { city = city, name = name, price = price, roomType = roomType, source=this.sourceName });
            }
            return result;
        }
    }

    public class BookingAdapter : IGetHotel
    {
        private string sourceName = "Booking.com";

        public List<Hotel> getHotelList()
        {
            BookingSystem bookingSystem = new BookingSystem();
            List<BookingHotel> bookingHotels = bookingSystem.getBookingHotelList();
            return this.processBookingHotels(bookingHotels);
        }

        private List<Hotel> processBookingHotels(List<BookingHotel> bookingHotels)
        {
            List<Hotel> hotels = new List<Hotel>();
            foreach(BookingHotel bh in bookingHotels)
            {
                string roomType="?";
                if (bh.roomSize == "BIG") roomType = "4";
                if (bh.roomSize == "MEDIUM") roomType = "2";
                if (bh.roomSize == "SMALL") roomType = "1";
                hotels.Add(new Hotel { city = bh.city, name = bh.name, price = bh.price, roomType =roomType,source=this.sourceName });
            }
            return hotels;
        }
    }
}