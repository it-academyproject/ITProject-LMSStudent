using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSStudent.Models
{
    public class Exercise
    {
        public int Id { get; set; }        
        public int AvailableTime { get; set; }

        public virtual Resource Resource { get; set; }
    }
}
