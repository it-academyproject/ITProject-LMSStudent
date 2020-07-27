using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMSStudent.Models
{
    public class Users
    {
        [Key]
        public long IdUSer { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public double type { get; set; }
        public long idItinerary { get; set; }
    }
}
