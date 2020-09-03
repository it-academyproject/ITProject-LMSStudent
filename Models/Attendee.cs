using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LMSStudent.Models
{
    public class Attendee
    {
        [Key]
        [ForeignKey("Student")]
        public long IdStudent { get; set; }
        [Key]
        [ForeignKey("Event")]
        public int IdEvent { get; set; }
        public DateTime Moment { get; set; } = DateTime.Now;
        public bool Accepted { get; set; } = false;

        /*public virtual User Student { get; set; }
        public virtual Event Event { get; set; }*/
    }
}
