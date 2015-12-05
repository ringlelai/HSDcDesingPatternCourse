using System.Collections.Generic;

namespace hsdc.dpt.Control.DTO.Creational.FactoryMethod
{
    public class GoogleMapDto : IMapView<Marker>
    {
        public string PageViewName => "GoogleMap";

        public Position Center { get; set; }

        public List<Marker> Positions { set; get; }
    }
}