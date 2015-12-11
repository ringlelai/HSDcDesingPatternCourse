using hsdc.dpt.Control.DTO.Structual.Homework3;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Homework3
{
    public interface IExternalSearchAdapter
    {
        List<RestaurantDto> Get();

        Task<List<RestaurantDto>> GetAsync();
    }
}