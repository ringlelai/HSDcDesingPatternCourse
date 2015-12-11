using System.Collections.Generic;

namespace hsdc.dpt.Control.DTO.Creational.FactoryMethod
{
    public class BingMapDto : IMapView<Pushpin>
    {
        public string PageViewName => "BingMap";

        public Position Center { get; set; }

        public List<Pushpin> Positions { get; set; }
    }
}