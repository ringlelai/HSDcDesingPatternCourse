using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.DTO.Creational.Builder
{
    public class Leave
    {
        public String LeaveID { get; set; }
        public String Applier { get; set; }
        public String LeaveType { get; set; }
        public int LeaveDay { get; set; }
        public DateTime LeaveBeginDate { get; set; }
    }

    public class ApplyExpense
    {
        public String ApplyExpenseID { get; set; }
        public String Applier { get; set; }
        public String ApplyExpenseType { get; set; }
        public decimal TotalExpense { 
            get 
            {
                decimal exp = 0;
                if (LineItems != null)
                    LineItems.ForEach(d => exp += d.Expense);
                return exp;
            } 
        }
        public DateTime ApplyDate { get; set; }
        public List<ApplyExpenseDetail> LineItems { get; set; }
    }

    public class ApplyExpenseDetail
    {
        public String ReferenceNumber { get; set; }
        public DateTime OccureDate { get; set; }
        public decimal Expense { get; set; }
    }
}
