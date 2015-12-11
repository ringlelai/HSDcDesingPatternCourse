using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Behavioral.Visitor
{
    /// <summary>
    /// The 'ConcreteVisitor' class.
    /// 計算公司每月固定支出費用 (針對員工薪資與辦公室開銷費用)
    /// </summary>
    public class PricingVisitor : Visitor
    {
        private int totalPrice;         // 總支出費用

        public override void VisitEmployee(Employee emp)
        {
            totalPrice += emp.salary;     // 累加所有員工薪資
        }

        public override void VisitOffice(Office office)
        {
            totalPrice += office.支出費用;      // 累加所有辦公室費用
        }

        public int getTotalPrice()
        {
            return this.totalPrice;
        }
    }

    /// <summary>
    /// The 'ConcreteVisitor' class.
    /// 統計公司資產總數 (員工人數與辦公室數目)
    /// </summary>
    public class InventoryVisitor : Visitor
    {
        private int totalInstances;     // 公司資產總數

        public override void VisitEmployee(Employee emp)
        {
            totalInstances++;       // 累計員工人數
        }

        public override void VisitOffice(Office office)
        {
            totalInstances++;       // 累計辦公室數目
        }

        public int getTotalInstances()
        {
            return totalInstances;
        }
    }
}
