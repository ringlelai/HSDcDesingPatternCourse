using System;

namespace hsdc.dpt.Control.DTO.Creational.Builder
{
    public class OverTime
    {
        public string OverTimeId { get; set; }

        public string Applier { get; set; }

        public DateTime ApplyDateTime { get; set; } = DateTime.Now.Date;

        public int OverTimeHour { get; set; } = 1;
    }
}