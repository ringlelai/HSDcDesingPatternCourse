using hsdc.dpt.Control.DTO.Structual.Homework3;
using System.Collections.Generic;
using System.Linq;

namespace hsdc.dpt.Control.Structural.Homework3
{
    internal class RestaurantDao : IRestaurantDao
    {
        private readonly RestaurantContext _context;

        public RestaurantDao()
        {
            _context = RestaurantContext.Instance;
        }

        public List<RestaurantDto> GetList()
        {
            return _context.Restaurants.Select(x => new RestaurantDto
            {
                Name = x.Name,
                Descript = x.Descript,
                Price = x.Price
            }).ToList();
        }
    }
}