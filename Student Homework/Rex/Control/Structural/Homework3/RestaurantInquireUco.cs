using hsdc.dpt.Control.DTO.Structual.Homework3;
using System.Collections.Generic;

namespace hsdc.dpt.Control.Structural.Homework3
{
    public class RestaurantInquireUco
    {
        private readonly IRestaurantDao _dao;
        private readonly bool _verification;

        public RestaurantInquireUco()
        {
            _dao = new RestaurantProxyDao(_verification);
        }

        public RestaurantInquireUco(bool verification)
        {
            _verification = verification;
            _dao = new RestaurantProxyDao(_verification);
        }

        internal RestaurantInquireUco(IRestaurantDao dao, bool verification)
        {
            _verification = verification;
            _dao = dao;
        }

        public List<RestaurantDto> GetPresetList()
        {
            return _dao.GetList();
        }
    }
}