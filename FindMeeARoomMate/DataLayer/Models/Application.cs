using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeeARoomMate.DataLayer.Models
{
    public class Application
    {
        [Key]
        public int ID { get; set; }

        //[ForeignKey("Applicant")]
        //public int ApplicantID { get; set; }
        //public Student Applicant { get; set; }

        [ForeignKey("Announcement")]
        [Required]
        public int AnnouncementID { get; set; }
        public Announcement Announcement { get; set; }
        public string Status { get; set; }
    }
}
