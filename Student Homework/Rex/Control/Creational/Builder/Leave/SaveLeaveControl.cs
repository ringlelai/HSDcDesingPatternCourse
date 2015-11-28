namespace hsdc.dpt.Control.Creational.Builder.Leave
{
    public class SaveLeaveControl
    {
        public DTO.Creational.Builder.Leave Save(DTO.Creational.Builder.Leave leave)
        {
            if (leave != null)
                leave.LeaveID = "LE010001";
            return leave;
        }
    }
}