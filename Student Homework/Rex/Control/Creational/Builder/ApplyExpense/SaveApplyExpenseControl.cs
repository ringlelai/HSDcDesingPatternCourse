namespace hsdc.dpt.Control.Creational.Builder.ApplyExpense
{
    public class SaveApplyExpenseControl
    {
        public DTO.Creational.Builder.ApplyExpense Save(DTO.Creational.Builder.ApplyExpense expense)
        {
            if (expense != null)
                expense.ApplyExpenseID = "AE010001";
            return expense;
        }
    }
}