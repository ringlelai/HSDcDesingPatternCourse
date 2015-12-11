using hsdc.dpt.Control.DTO.Structual.Homework3;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Homework3
{
    internal class RestaurantProxyDao : IRestaurantDao
    {
        private readonly bool _verification;
        private readonly RestaurantDao _restaurantDao;
        private readonly IEnumerable<IExternalSearchAdapter> _adapters;

        public RestaurantProxyDao(bool verification)
        {
            _verification = verification;
            _restaurantDao = new RestaurantDao();
            _adapters = new List<IExternalSearchAdapter>
                        {
                            new ExpediaSearchAdaptee(),
                        };
        }

        internal RestaurantProxyDao(bool verification, IEnumerable<IExternalSearchAdapter> adapters)
        {
            _verification = verification;
            _restaurantDao = new RestaurantDao();
            _adapters = adapters;
        }

        public List<RestaurantDto> GetList()
        {
            List<RestaurantDto> result = _restaurantDao.GetList();

            if (_verification == false) return result;

            ConcurrentBag<RestaurantDto> external = new ConcurrentBag<RestaurantDto>();

            Parallel.ForEach(_adapters, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount }, adapter =>
             {
                 var query = adapter.Get();

                 foreach (var restaurantDto in query)
                 {
                     external.Add(restaurantDto);
                 }
             });

            result.InsertRange(0, external);

            return result;
        }
    }
}