using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeeARoomMate.DataLayer.Models
{
    public class Announcement
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [ForeignKey("CreatedBy")]
        [Required]
        public int CreatedByID { get; set; }
        public Student CreatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
