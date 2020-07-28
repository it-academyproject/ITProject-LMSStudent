using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSStudent.Models
{
    public class StudentCheck
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int UserId { get; set; }
        public string File { get; set; }
        public string Status { get; set; }

        public Resource Resource { get; set; }

        //public User User { get; set; }
    }
}
