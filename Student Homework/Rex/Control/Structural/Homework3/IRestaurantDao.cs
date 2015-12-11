using hsdc.dpt.Control.DTO.Structual.Homework3;
using System.Collections.Generic;

namespace hsdc.dpt.Control.Structural.Homework3
{
    internal interface IRestaurantDao
    {
        List<RestaurantDto> GetList();
    }
}