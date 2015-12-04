using System.Collections.Generic;
using System.Web.Mvc;

namespace WebMVC.Controllers.Creational
{
    public class MapFactoryMethodController : Controller
    {
        // GET: MapFactoryMethod
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult MapService()
        {
            return View("MapService");
        }
    }

    public interface IMapService<T>
    {
    }

    //public class GoogleMapService : IMapService<>
    //{
    //}

    //public class BingMapService : IMapService<>
    //{
    //}

    public interface ILocationMarker
    {
        string Id { get; set; }

        string Name { get; set; }

        decimal Lat { get; set; }

        decimal Lng { get; set; }
    }

    public interface IMapView
    {
        IEnumerable<ILocationMarker> Markers { get; set; }

        string ViewName { get; set; }
    }
}