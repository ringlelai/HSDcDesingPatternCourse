using System;
using System.ComponentModel.DataAnnotations;

namespace hsdc.dpt.Control.DTO.Creational.Builder
{
    public class OverTime
    {
        public string OverTimeId { get; set; }

        [Required]
        public string Applier { get; set; }

        [Required]
        public DateTime ApplyDateTime { get; set; } = DateTime.Now.Date;

        [Range(1, 8, ErrorMessage = "最小為 1 小時 ， 最大 8 小時")]
        public int OverTimeHour { get; set; } = 1;
    }
}