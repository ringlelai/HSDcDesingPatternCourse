using System;
using System.ComponentModel.DataAnnotations;

namespace WebMVC.ViewModels.Builder
{
    public class NewOverTimeViewModel
    {
        public string OverTimeId { get; set; }

        [Required]
        public string Applier { get; set; }

        [Required]
        public DateTime ApplyDateTime { get; set; }

        [Range(1, 8, ErrorMessage = "最小為 1 小時 ， 最大 8 小時")]
        public int OverTimeHour { get; set; }
    }
}