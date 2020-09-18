﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMSStudent.Models
{
    public class User: IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Type { get; set; }
        public int? ItineraryId { get; set; }

        public virtual Itinerary Itinerary { get; set; }
    }
}
