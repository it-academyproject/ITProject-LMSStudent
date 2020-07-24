using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSStudent.Models
{
    public class TeachingMaterial
    {
        public int Id { get; set; }        
        public string Type { get; set; }
        public string Link { get; set; }

        public virtual Resource Resource { get; set; }

    }
}
