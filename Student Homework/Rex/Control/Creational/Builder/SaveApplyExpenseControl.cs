using hsdc.dpt.Control.DTO.Creational.Builder;

namespace hsdc.dpt.Control.Creational.Builder
{
    public class SaveApplyExpenseControl
    {
        public ApplyExpense Save(ApplyExpense expense)
        {
            if (expense != null)
                expense.ApplyExpenseID = "AE010001";
            return expense;
        }
    }
}