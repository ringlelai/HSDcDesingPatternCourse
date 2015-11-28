using hsdc.dpt.Control.Behavioral.FactoryMethod.Singleton;
using hsdc.dpt.Control.DTO.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.FactoryMethod.Erp
{
    public abstract class MaintianUcoCreator<T>
    {
        protected abstract MaintainJobDao<T> CreateMaintaionJob();
        public List<T> ListAll()
        {
            MaintainJobDao<T> dao = CreateMaintaionJob();
            List<T> returnVal = dao.Read();
            BusinessRuleCheck(ref returnVal);
            return returnVal;
        }
        protected abstract void BusinessRuleCheck(ref List<T> obj);
    }

    public abstract class MaintainJobDao<T>
    {
        public abstract void Create(T obj);
        public abstract List<T> Read();
        public abstract void Update(T obj);
        public abstract void Delete(T obj);
    }

    public class MaintainCustomerUco : MaintianUcoCreator<Customer>
    {
        protected override MaintainJobDao<Customer> CreateMaintaionJob()
        {
            return new MaintainCustomerDao();
        }

        protected override void BusinessRuleCheck(ref List<Customer> obj)
        {
            // do nothing
        }
    }

    public class MaintainSupplierUco : MaintianUcoCreator<Supplier>
    {
        protected override MaintainJobDao<Supplier> CreateMaintaionJob()
        {
            return new MaintainSupplierDao();
        }

        protected override void BusinessRuleCheck(ref List<Supplier> obj)
        {
        }
    }

    public class MaintainProductUco : MaintianUcoCreator<Product>
    {
        protected override MaintainJobDao<Product> CreateMaintaionJob()
        {
            return new MaintainProductDao();
        }

        protected override void BusinessRuleCheck(ref List<Product> obj)
        {
            obj.RemoveAll(p => p.IsDelete);
        }
    }


    public class MaintainCustomerDao : MaintainJobDao<Customer>
    {
        public override void Create(Customer obj)
        {
            throw new NotImplementedException();
        }

        public override List<Customer> Read()
        {
            return Db.Instance.Customers();
        }

        public override void Update(Customer obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Customer obj)
        {
            throw new NotImplementedException();
        }
    }

    public class MaintainSupplierDao : MaintainJobDao<Supplier>
    {
        public override void Create(Supplier obj)
        {
            throw new NotImplementedException();
        }

        public override List<Supplier> Read()
        {
            return Db.Instance.Suppliers();
        }

        public override void Update(Supplier obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Supplier obj)
        {
            throw new NotImplementedException();
        }
    }

    public class MaintainProductDao : MaintainJobDao<Product>
    {
        public override void Create(Product obj)
        {
            throw new NotImplementedException();
        }

        public override List<Product> Read()
        {
            return Db.Instance.Products();
        }

        public override void Update(Product obj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Product obj)
        {
            throw new NotImplementedException();
        }
    }





}
