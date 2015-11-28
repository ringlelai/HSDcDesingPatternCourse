using System;

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
}