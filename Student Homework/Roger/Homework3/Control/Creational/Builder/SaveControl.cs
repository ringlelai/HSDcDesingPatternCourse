using hsdc.dpt.Control.DTO.Creational.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hsdc.dpt.Control.Creational.Builder
{
    public class SaveLeaveControl
    {
        public Leave Save(Leave leave)
        {
            if (leave != null)
                leave.LeaveID = "LE010001";
            return leave;
        }
    }

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
