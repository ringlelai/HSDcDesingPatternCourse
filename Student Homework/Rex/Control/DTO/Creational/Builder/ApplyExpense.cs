using System;
using System.Collections.Generic;

namespace hsdc.dpt.Control.DTO.Creational.Builder
{
    public class ApplyExpense
    {
        public String ApplyExpenseID { get; set; }
        public String Applier { get; set; }
        public String ApplyExpenseType { get; set; }

        public decimal TotalExpense
        {
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
        public string Detail { get; set; }
    }
}