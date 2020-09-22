using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSStudent.Models
{
    public class LMSStudentContext : IdentityDbContext<User>
    {
        public LMSStudentContext(DbContextOptions<LMSStudentContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Attendee>().HasKey(c => new { c.IdStudent, c.IdEvent });
            base.OnModelCreating(builder);
        }

        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<TeachingMaterial> TeachingMaterials { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Itinerary> Itineraries { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
