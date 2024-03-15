using ITI_Map.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Map.Context
{
    internal class ITIDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =ELNAHAS\\SQLEXPRESS; database=ITIDb; trusted_connection=true;");
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Departments> departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Course_> courses { get; set; }
        public DbSet<Topic> topics { get; set; }


        public DbSet<Stud_Course> Stud_Courses { get; set; }

        public DbSet<Course_Instructot> course_Instructots { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            


               modelBuilder.Entity<Stud_Course>()
                   .HasKey(x => new { x.StudId, x.CourseId });


            modelBuilder.Entity<Course_Instructot>()
               .HasKey(x => new { x.CourseId, x.Instructorid });
        }

    }
    }

