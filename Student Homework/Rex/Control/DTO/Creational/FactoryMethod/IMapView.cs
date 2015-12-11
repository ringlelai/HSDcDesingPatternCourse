using System.Collections.Generic;

namespace hsdc.dpt.Control.DTO.Creational.FactoryMethod
{
    public interface IMapView<T>
    {
        string PageViewName { get; }

        Position Center { get; set; }

        List<T> Positions { set; get; }
    }
}