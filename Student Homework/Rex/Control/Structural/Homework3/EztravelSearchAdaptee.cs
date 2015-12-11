using hsdc.dpt.Control.DTO.Structual.Homework3;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Homework3
{
    public class EztravelSearchAdaptee : IExternalSearchAdapter
    {
        public List<RestaurantDto> Get()
        {
            // Need Parser Html 懶得寫了= =
            throw new System.NotImplementedException();
        }

        public Task<List<RestaurantDto>> GetAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}