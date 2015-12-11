using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using System.Collections.Generic;
using System.Linq;

namespace hsdc.dpt.Control.Creational.FactoryMethod
{
    //https://msdn.microsoft.com/en-us/library/hh709044.aspx
    public class BingMapUco : IMapUcoCreator<BingMapDto>
    {
        private readonly MapSampleDataDao _dao;

        public BingMapUco()
        {
            _dao = new MapSampleDataDao();
        }

        public BingMapDto GetViewModel(Position center)
        {
            List<Position> positions = _dao.GetList();

            BingMapDto dto = new BingMapDto()
            {
                Center = positions.First(),
                Positions = positions.Select(ConvertToDto).ToList()
            };

            return dto;
        }

        private static Pushpin ConvertToDto(Position position)
        {
            Pushpin marker = new Pushpin
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