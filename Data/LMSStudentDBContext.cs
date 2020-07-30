using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSStudent.Models
{
    public class LMSStudentDBContext: DbContext
    {
        public LMSStudentDBContext()
        {

        }

        public LMSStudentDBContext(DbContextOptions<LMSStudentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Exercise> Exercises { get; set; }
        public virtual DbSet<TeachingMaterial> TeachingMaterials { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
