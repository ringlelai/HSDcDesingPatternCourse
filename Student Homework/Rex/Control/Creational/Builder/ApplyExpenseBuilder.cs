using hsdc.dpt.Control.DTO.Creational.Builder;
using System.Collections.Generic;

namespace hsdc.dpt.Control.Creational.Builder
{
    public class ApplyExpenseBuilder : IOfficeFormBuilder<ApplyExpense>
    {
        private ApplyExpense _dto;

        public void BuildMaster()
        {
            _dto = new ApplyExpense();
        }

        public void BuildDetails()
        {
            _dto.LineItems = new List<ApplyExpenseDetail>();
        }

        public ApplyExpense GetResult()
        {
            return _dto;
        }
    }
}