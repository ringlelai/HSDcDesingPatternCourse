using System.Collections.Generic;
using hsdc.dpt.Control.DTO.Creational.Builder;

namespace hsdc.dpt.Control.Creational.Builder.ApplyExpense
{
    public class ApplyExpenseBuilder : IOfficeFormBuilder<DTO.Creational.Builder.ApplyExpense>
    {
        private DTO.Creational.Builder.ApplyExpense _dto;

        public void BuildMaster()
        {
            _dto = new DTO.Creational.Builder.ApplyExpense();
        }

        public void BuildDetails()
        {
            _dto.LineItems = new List<ApplyExpenseDetail>();
        }

        public DTO.Creational.Builder.ApplyExpense GetResult()
        {
            return _dto;
        }
    }
}