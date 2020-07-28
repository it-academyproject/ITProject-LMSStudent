using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSStudent.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string File { get; set; }
        public bool Online { get; set; }
        public int? Capacity { get; set; }
        public string Type { get; set; }
    }
}
