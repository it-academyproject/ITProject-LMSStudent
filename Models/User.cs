using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMSStudent.Models
{
    public class User: IdentityUser
    {
        [Key]
        public long IdUser { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Type { get; set; }
        public long IdItinerary { get; set; }
    }
}
