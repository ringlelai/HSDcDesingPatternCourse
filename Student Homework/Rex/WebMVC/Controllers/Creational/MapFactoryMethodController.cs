using System.Web.Mvc;
using hsdc.dpt.Control.Creational.FactoryMethod;
using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using WebMVC.ViewModels.MapFactoryMethod;

namespace WebMVC.Controllers.Creational
{
    public class MapFactoryMethodController : Controller
    {
        #region Map Index

        public ActionResult Index()
        {
            return View("Index");
        }

        #endregion Map Index

        #region Google Map

        public ActionResult GoogleMap(Position center)
        {
            GoogleMapUco uco = new GoogleMapUco();

            GoogleMapDto dto = uco.GetViewModel(center);

            GoogleMapViewModel vm = ConvertToViewModel(dto);

            return View(dto.PageViewName, vm);
        }

        private static GoogleMapViewModel ConvertToViewModel(GoogleMapDto dto)
        {
            return new GoogleMapViewModel
            {
                Center = dto.Center,
                Markers = dto.Positions
            };
        }

        #endregion Google Map

        #region Bing Map

        public ActionResult BingMap(Position center)
        {
            BingMapUco uco = new BingMapUco();

            BingMapDto dto = uco.GetViewModel(center);

            var vm = ConvertToViewModel(dto);

            return View(dto.PageViewName, vm);
        }

        private static BingMapViewModel ConvertToViewModel(BingMapDto dto)
        {
            BingMapViewModel vm = new BingMapViewModel
            {
                Center = dto.Center,
                Pushpins = dto.Positions
            };
            return vm;
        }

        #endregion Bing Map
    }
}