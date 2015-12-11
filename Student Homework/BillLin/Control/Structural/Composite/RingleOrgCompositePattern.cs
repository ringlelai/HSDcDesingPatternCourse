using hsdc.dpt.Control.DTO.Structual.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Composite.RingleOrg
{
    public abstract class OrganizationUnit
    {
        protected List<Employee> empList;
        public abstract List<Employee> GetAllEmployee();
        public virtual List<OrganizationUnit> GetChildren()
        {
            return new List<OrganizationUnit>();
        }
        public string DepartmentName { get; set; }
        public virtual void Add(OrganizationUnit child)
        {
        }
        public virtual void Remove(OrganizationUnit child)
        {
        }
        public virtual OrganizationUnit GetChild(int index)
        {
            return null;
        }
        public void AddEmployee(Employee emp)
        {
            if (empList == null)
                empList = new List<Employee>();
            empList.Add(emp);
        }
        public virtual OrganizationUnit GetUnit(string deptName)
        {
            if (DepartmentName.Equals(deptName))
                return this;
            return null;
        }
    }

    public sealed class OrganizationUnitLeaf : OrganizationUnit
    {
        public override List<Employee> GetAllEmployee()
        {
            return this.empList;
        }
    }

    public sealed class OrganizationUnitComposite : OrganizationUnit
    {
        private List<OrganizationUnit> children;
        public override List<Employee> GetAllEmployee()
        {
            List<Employee> allEmp = new List<Employee>();
            allEmp.AddRange(this.empList);
            foreach (OrganizationUnit g in children)
                allEmp.AddRange(g.GetAllEmployee());
            return allEmp;
        }
        public override void Add(OrganizationUnit child)
        {
            if (children == null)
                children = new List<OrganizationUnit>();
            children.Add(child);
        }

        public override void Remove(OrganizationUnit child)
        {
            if (children == null)
                return;
            children.Remove(child);
        }

        public override OrganizationUnit GetChild(int index)
        {
            if (children == null)
                return null;
            return children[index];
        }

        public override List<OrganizationUnit> GetChildren()
        {
            List<OrganizationUnit> orgs = new List<OrganizationUnit>();
            orgs.AddRange(children);
            foreach (OrganizationUnit child in children)
                orgs.AddRange(child.GetChildren());
            return orgs;
        }

        public override OrganizationUnit GetUnit(string deptName)
        {
            OrganizationUnit ou = base.GetUnit(deptName);
            if (ou != null)
                return ou;
            foreach (OrganizationUnit g in children)
            {
                ou = g.GetUnit(deptName);
                if (ou != null)
                    return ou;
            }
            return ou;
        }
    }
}
