using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<TeachersStudent> TeachersStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TeachersStudent>(e =>
            {
                e.HasKey(t => new { t.StudentId, t.TeacherId });
            });

            modelBuilder.Entity<TeachersStudent>(e =>
            {
                e.HasOne(ts => ts.Student).WithMany(s => s.Teachers);

                e.HasOne(ts => ts.Teacher).WithMany(t => t.Students);
            });
        }
    }
}
