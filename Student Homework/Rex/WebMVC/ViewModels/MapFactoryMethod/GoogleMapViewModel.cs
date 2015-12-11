using System.Collections.Generic;
using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using WebMVC.Controllers.Creational;

namespace WebMVC.ViewModels.MapFactoryMethod
{
    public class GoogleMapViewModel
    {
        public Position Center { get; set; }

        public List<Marker> Markers { set; get; }
    }
}