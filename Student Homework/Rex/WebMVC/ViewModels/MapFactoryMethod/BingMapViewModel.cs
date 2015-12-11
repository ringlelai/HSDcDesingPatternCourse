using System.Collections.Generic;
using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using WebMVC.Controllers.Creational;

namespace WebMVC.ViewModels.MapFactoryMethod
{
    public class BingMapViewModel
    {
        public Position Center { get; set; }

        public List<Pushpin> Pushpins { set; get; }
    }
}