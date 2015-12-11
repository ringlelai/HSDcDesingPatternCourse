using hsdc.dpt.Control.DTO.Structual.Homework3;
using hsdc.dpt.Control.Structural.Homework3;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebMVC.ViewModels.Homework3;

namespace WebMVC.Controllers.Structural
{
    public class Homework3Controller : Controller
    {
        // GET: Homework3
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Level1()
        {
            RestaurantInquireUco uco = new RestaurantInquireUco();

            List<RestaurantDto> dtos = uco.GetPresetList();

            List<RestaurantViewModel> vms = ConvertToViewModel(dtos);

            return View("Level", vms);
        }

        public ActionResult Level2()
        {
            RestaurantInquireUco uco = new RestaurantInquireUco(true);

            List<RestaurantDto> dtos = uco.GetPresetList();

            List<RestaurantViewModel> vms = ConvertToViewModel(dtos);

            return View("Level", vms);
        }

        /// <summary>
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        private static List<RestaurantViewModel> ConvertToViewModel(IEnumerable<RestaurantDto> dtos)
        {
            return dtos.Select(x => new RestaurantViewModel
            {
                Name = x.Name,
                Descript = x.Descript,
                Price = x.Price,
                ThumbnailUrl = x.ThumbnailUrl,
                InfoSiteUrl = x.InfoSiteUrl
            }).ToList();
        }
    }
}