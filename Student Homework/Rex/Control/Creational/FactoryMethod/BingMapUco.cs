using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using System;
using System.Collections.Generic;

namespace hsdc.dpt.Control.Creational.FactoryMethod
{
    //https://msdn.microsoft.com/en-us/library/hh709044.aspx
    public class BingMapUco : IMapUcoCreator<BingMapDto>
    {
        public BingMapDto GetViewModel(Position center)
        {
            throw new System.NotImplementedException();
        }
    }

    internal class MapSampleDataContext
    {
        private static volatile MapSampleDataContext _instance;
        private static readonly object SyncRoot = new object();

        internal static MapSampleDataContext Instance
        {
            get
            {
                if (_instance != null) return _instance;

                lock (SyncRoot)
                {
                    if (_instance == null)
                        _instance = new MapSampleDataContext();
                }

                return _instance;
            }
        }

        private MapSampleDataContext()
        {
            //25.06350	121.52225
            Positions = Generator(new decimal(25.06350), new decimal(121.52225), 15);
        }

        private static List<Position> Generator(decimal lat, decimal lng, int conut)
        {
            List<Position> positions = new List<Position>()
            {
                new Position() {Id = 1 , Name = "中心座標" ,}
            };

            Random random = new Random();

            var len = random.Next(10, 15);

            for (int i = 1; i < len; i++)
            {
                decimal x = (decimal)((float)random.Next(1, 10) / 1000);
                decimal y = (decimal)((float)random.Next(1, 10) / 1000);
                Position position = new Position
                {
                    Id = i,
                    Name = $"周圍座標 {i}",
                    Lat = lat + x,
                    Lng = lng + y
                };
                positions.Add(position);
            }
            return positions;
        }

        public List<Position> Positions { get; private set; }
    }
}