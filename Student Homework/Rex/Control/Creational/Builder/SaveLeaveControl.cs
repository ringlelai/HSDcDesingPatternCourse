using hsdc.dpt.Control.DTO.Creational.Builder;

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
}