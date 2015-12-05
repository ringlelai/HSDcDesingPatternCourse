using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using System.Collections.Generic;

namespace hsdc.dpt.Control.Creational.FactoryMethod
{
    internal class MapSampleDataDao
    {
        private readonly MapSampleDataContext _context;

        public MapSampleDataDao()
        {
            _context = MapSampleDataContext.Instance;
        }

        public MapSampleDataDao(MapSampleDataContext context)
        {
            _context = context;
        }

        public List<Position> GetList()
        {
            return _context.Positions;
        }
    }
}