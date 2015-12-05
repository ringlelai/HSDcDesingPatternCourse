using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using System.Collections.Generic;
using System.Linq;

namespace hsdc.dpt.Control.Creational.FactoryMethod
{
    // https://github.com/ericnewton76/gmaps-api-net
    public class GoogleMapUco : IMapUcoCreator<GoogleMapDto>
    {
        private readonly MapSampleDataDao _dao;

        public GoogleMapUco()
        {
            _dao = new MapSampleDataDao();
        }

        public GoogleMapDto GetViewModel(Position center)
        {
            List<Position> positions = _dao.GetList();

            GoogleMapDto dto = new GoogleMapDto()
            {
                Center = positions.First(),
                Positions = positions.Select(ConvertToDto).ToList()
            };

            return dto;
        }

        private static Marker ConvertToDto(Position position)
        {
            Marker marker = new Marker
            {
                Id = position.Id,
                Name = position.Name,
                Lat = position.Lat,
                Lng = position.Lng
            };

            return marker;
        }
    }
}