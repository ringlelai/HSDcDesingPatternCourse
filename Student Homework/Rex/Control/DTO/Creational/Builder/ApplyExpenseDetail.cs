using System;

namespace hsdc.dpt.Control.DTO.Creational.Builder
{
    public abstract class ApplyExpenseDetail
    {
        public String ReferenceNumber { get; set; }
        public DateTime OccureDate { get; set; }
        public decimal Expense { get; set; }
    }
}