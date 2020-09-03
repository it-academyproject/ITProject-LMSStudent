using Microsoft.EntityFrameworkCore;

namespace LMSStudent.Models
{
    public class AttendeeContext : DbContext
    {
        public AttendeeContext(DbContextOptions<AttendeeContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Attendee>().HasKey(c => new { c.IdStudent, c.IdEvent });
            base.OnModelCreating(builder);
        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
