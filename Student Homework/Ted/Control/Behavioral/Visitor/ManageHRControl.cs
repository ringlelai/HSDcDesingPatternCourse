using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Visitor
{
    /// <summary>
    /// The 'Client' Class.
    /// 操作兩類 Visitor：計算公司每月所有開銷費用，以及公司資產總數
    /// </summary>
    public class ManageHRControl
    {
        private PricingVisitor _pricingVisitor;         // 計算每月開銷費用的 Visitor
        private InventoryVisitor _inventoryVisitor;     // 計算公司資產的 Visitor

        private int empTotalSalary;             // 所有員工總應付薪資
        private int officeTotalExpense;         // 所有辦公室總開銷費用
        private int totalEmployees;             // 員工總數
        private int totalOffices;               // 辦公室總數
       
        // Constructor
        public ManageHRControl()
        {
            _pricingVisitor = new PricingVisitor();
            _inventoryVisitor = new InventoryVisitor();
        }

        public string calc公司每月固定支出()
        {
            string result = "本月資產支出明細報表：\n" +
                            "================================\n\n";

            result += this.get員工薪資明細() + "\n\n";
            result += this.getOffice開銷明細();
            result += "\n\n\n" +
                      "所有開銷費用總計： " + (empTotalSalary + officeTotalExpense).ToString();
                        
            return result;
        }

        private string get員工薪資明細()
        {
            string salaryDetail = "";

            List<Employee> employees = this.getEmployees();

            foreach (Employee e in employees)
            {
                e.Accept(_pricingVisitor);
                salaryDetail += e.GetType().Name + "： " + e.name + " ,應付薪資：" + e.salary.ToString() + "\n";
            }

            salaryDetail += "-----------------------------------------------------\n";
            salaryDetail += "本月應付員工總薪資為： " + _pricingVisitor.getTotalPrice().ToString() + "\n\n";
            salaryDetail += "================================";

            empTotalSalary = _pricingVisitor.getTotalPrice();

            return salaryDetail;
        }
       
        private string getOffice開銷明細()
        {
            string expenseDetail = "";

            List<Office> offices = this.getOffices();

            foreach (Office o in offices)
            {
                o.Accept(_pricingVisitor);
                expenseDetail += o.GetType().Name + "： " + o.name + " ,開銷費用：" + o.支出費用.ToString() + "\n";
            }

            officeTotalExpense = _pricingVisitor.getTotalPrice() - empTotalSalary;

            expenseDetail += "-----------------------------------------------------\n";
            expenseDetail += "本月所有辦公室開銷費用為： " + officeTotalExpense.ToString() + "\n\n";
            expenseDetail += "================================";

            return expenseDetail;
        }


        // 統計公司資產。包括員工人數、辦公室數目等。
        public string calce公司資產總數()
        {
            string result = "本公司所有資產 (員工、辦公司)統計：\n" +
                            "================================\n\n";

            result += this.get員工人數() + "\n\n" +
                this.getOffice數目();

            return result;
        }

        private string get員工人數()
        {
            string empDetail = "";

            List<Employee> employees = this.getEmployees();

            foreach (Employee e in employees)
            {
                e.Accept(_inventoryVisitor);
                empDetail += e.GetType().Name + "： " + e.name + "\n";
            }

            totalEmployees = _inventoryVisitor.getTotalInstances();
            empDetail += "-----------------------------------------------------\n";
            empDetail += "員工總人數： " + totalEmployees.ToString() + "\n\n";
            empDetail += "================================";
            
            return empDetail;
        }

        private string getOffice數目()
        {
            string officeDetail = "";

            List<Office> offices = this.getOffices();

            foreach (Office o in offices)
            {
                o.Accept(_inventoryVisitor);
                officeDetail += o.GetType().Name + "： " + o.name + "\n";
            }

            totalOffices = _inventoryVisitor.getTotalInstances() - totalEmployees;
            officeDetail += "-----------------------------------------------------\n";
            officeDetail += "辦公室總數： " + totalOffices.ToString() + "\n\n";
            officeDetail += "================================";

            return officeDetail;
        }

        // 使用 List<T> 當為 in-memory 的儲庫 (repository)
        private List<Employee> getEmployees()
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Clerk("鳥哥", 36000));
            empList.Add(new Clerk("阿天", 32000));
            empList.Add(new Clerk("尚青", 46000));
            empList.Add(new Manager("班森", 78000));
            empList.Add(new Manager("棒棒伯", 88000));

            return empList;
        }

        // 使用 List<T> 當為 in-memory 的儲庫 (repository)
        private List<Office> getOffices()
        {
            List<Office> officeList = new List<Office>();

            officeList.Add(new Office("101大樓88F88室", 240000));
            officeList.Add(new Office("烘爐地資訊室", 68000));

            return officeList;
        }
    }
}
