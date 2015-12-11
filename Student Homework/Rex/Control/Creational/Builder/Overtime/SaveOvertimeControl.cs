using hsdc.dpt.Control.DTO.Creational.Builder;
using System;

namespace hsdc.dpt.Control.Creational.Builder.Overtime
{
    public class SaveOvertimeControl
    {
        public OverTime Save(OverTime model)
        {
            model.OverTimeId = $"LE{DateTime.Now.Ticks}";
            return model;
        }
    }
}