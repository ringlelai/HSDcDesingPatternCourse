using hsdc.dpt.Control.Behavioral.Mediator.Singleton;
using hsdc.dpt.Control.DTO.Behavioral.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Mediator
{
    public class StockingUco
    {

        public List<Product> GetAllProducts()
        {
            return Db.Instance.GetStocking().Select(d => new Product() { ProductName = d.Product.ProductName }).ToList();
        }

        public bool CheckQunatity(string prodName)
        {
            return Db.Instance.GetStocking().Where(s => s.Product.ProductName == prodName).SingleOrDefault().Quantity == 0;
        }
    }
}
