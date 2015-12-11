using hsdc.dpt.Control.DTO.Structual.Composite;
using hsdc.dpt.Control.Structural.Composite.RingleOrg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Structural.Composite
{
    public class RingelOrgControl
    {
        public List<string> GetAllDepartmentName()
        {
            OrganizationUnit root = GetAllDepartments();
            List<string> depts = new List<string>();
            depts.Add(root.DepartmentName);
            foreach (OrganizationUnit u in root.GetChildren()) {
                depts.Add(u.DepartmentName);
            }
            return depts;
        }

        public List<string> GetAllEmployeeName(string deptName)
        {
            OrganizationUnit ou = GetDepartment(deptName);
            List<string> emps = new List<string>();
            foreach (Employee e in ou.GetAllEmployee()) 
            {
                emps.Add(e.Name);
            }
            return emps;
        }

        private OrganizationUnit GetDepartment(string deptName)
        {
            OrganizationUnit root = GetAllDepartments();
            return root.GetUnit(deptName);
        }

        private OrganizationUnit GetAllDepartments()
        {
            OrganizationUnit leaf, comp, root;
            leaf = new OrganizationUnitLeaf();
            leaf.DepartmentName = "資訊課";
            Employee e1 = new Employee();
            e1.Name = "王小明";
            leaf.AddEmployee(e1);
            e1 = new Employee();
            e1.Name = "賴阿仁";
            leaf.AddEmployee(e1);
            comp = new OrganizationUnitComposite();
            comp.DepartmentName = "行政部";
            e1 = new Employee();
            e1.Name = "趙六";
            comp.AddEmployee(e1);
            e1 = new Employee();
            e1.Name = "錢七";
            comp.AddEmployee(e1);
            e1 = new Employee();
            e1.Name = "孫八";
            comp.AddEmployee(e1);
            comp.Add(leaf);
            leaf = new OrganizationUnitLeaf();
            leaf.DepartmentName = "人資課";
            e1 = new Employee();
            e1.Name = "趙守志";
            leaf.AddEmployee(e1);
            e1 = new Employee();
            e1.Name = "吳人來";
            leaf.AddEmployee(e1);
            comp.Add(leaf);
            root = new OrganizationUnitComposite();
            root.DepartmentName = "總經理室";
            e1 = new Employee();
            e1.Name = "王一";
            root.AddEmployee(e1);
            e1 = new Employee();
            root.AddEmployee(e1);
            e1.Name = "王二";
            root.Add(comp);
            leaf = new OrganizationUnitLeaf();
            leaf.DepartmentName = "出納課";
            e1 = new Employee();
            e1.Name = "錢出去";
            leaf.AddEmployee(e1);
            comp = new OrganizationUnitComposite();
            comp.DepartmentName = "財務部";
            e1 = new Employee();
            e1.Name = "李四";
            comp.AddEmployee(e1);
            comp.Add(leaf);
            leaf = new OrganizationUnitLeaf();
            leaf.DepartmentName = "會計課";
            e1 = new Employee();
            e1.Name = "錢多多";
            leaf.AddEmployee(e1);
            e1 = new Employee();
            e1.Name = "錢守住";
            leaf.AddEmployee(e1);
            comp.Add(leaf);
            root.Add(comp);
            comp = new OrganizationUnitComposite();
            comp.DepartmentName = "營業部";
            e1 = new Employee();
            e1.Name = "張三";
            comp.AddEmployee(e1);
            e1 = new Employee();
            e1.Name = "張五";
            comp.AddEmployee(e1);
            leaf = new OrganizationUnitLeaf();
            leaf.DepartmentName = "營業二課";
            e1 = new Employee();
            e1.Name = "鄭十一";
            leaf.AddEmployee(e1);
            e1 = new Employee();
            e1.Name = "歐陽十二";
            leaf.AddEmployee(e1);
            e1 = new Employee();
            e1.Name = "賴十三";
            leaf.AddEmployee(e1);
            comp.Add(leaf);
            leaf = new OrganizationUnitLeaf();
            leaf.DepartmentName = "營業一課";
            e1 = new Employee();
            e1.Name = "周九";
            leaf.AddEmployee(e1);
            e1 = new Employee();
            e1.Name = "吳十";
            leaf.AddEmployee(e1);
            comp.Add(leaf);
            root.Add(comp);
            return root;
        }
    }
}
