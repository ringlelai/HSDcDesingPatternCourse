using hsdc.dpt.Control.DTO.Structual.Homework3;
using hsdc.dpt.Control.DTO.Structual.Homework3.Expedia;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Homework3
{
    public class ExpediaSearchAdaptee : IExternalSearchAdapter
    {
        public List<RestaurantDto> Get()
        {
            string json = ExpediaSite.Instance.Responsed;

            var query = JsonConvert.DeserializeObject<ExpediaRootDto>(json);

            List<RestaurantDto> result = query.results.Select(x => new RestaurantDto
            {
                Name = x.retailHotelInfoModel.localizedHotelName,
                Descript = x.retailHotelInfoModel.hotelDescription,
                Price = (int)x.retailHotelPricingModel.price,
                ThumbnailUrl = x.retailHotelInfoModel.largeThumbnailURL,
                InfoSiteUrl = x.infositeUrl
            }).ToList();

            return result;
        }

        public async Task<List<RestaurantDto>> GetAsync()
        {
            Task<string> json = ExpediaSite.Instance.ResponsedAsync;

            var query = JsonConvert.DeserializeObject<ExpediaRootDto>(await json);

            List<RestaurantDto> result = query.results.Select(x => new RestaurantDto
            {
                Name = x.retailHotelInfoModel.localizedHotelName,
                Descript = x.retailHotelInfoModel.hotelDescription,
                Price = (int)x.retailHotelPricingModel.price,
                ThumbnailUrl = x.retailHotelInfoModel.largeThumbnailURL,
                InfoSiteUrl = x.infositeUrl
            }).ToList();

            return result;
        }
    }
}