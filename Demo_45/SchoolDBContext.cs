using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_45
{
    public class SchoolDBContext:DbContext
    {
        public SchoolDBContext(): base("SchoolDBConnectionString")
        {
           
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Admin");

            //table students
            modelBuilder.Entity<Student>().ToTable("Students");
            modelBuilder.Entity<Student>().HasKey<int>(s => s.StudentID);
            modelBuilder.Entity<Student>().Property(p => p.StudentName).HasMaxLength(50).IsConcurrencyToken();

            modelBuilder.Entity<Student>().Property(p => p.Height).IsOptional();

            //table grades
            modelBuilder.Entity<Grade>().ToTable("Grades");
            modelBuilder.Entity<Grade>().HasKey<int>(s => s.GradeId);
           


        }
    }
}
