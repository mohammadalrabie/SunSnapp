using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SunSnap.Models
{
    public class Photo
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [StringLength(255)]
        public string FileName { get; set; } 

        [Required]
        [StringLength(500)]
        public string FilePath { get; set; } 

        [StringLength(500)]
        public DateTime UploadDate { get; set; }

        public TimeSpan PeriodStart { get; set; }  
        public TimeSpan PeriodEnd { get; set; }
    }


}
