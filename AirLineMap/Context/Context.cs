using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AirLineMap.Context
{
    public class Context : DbContext
    {

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("server =ELNAHAS\\SQLEXPRESS; database=AirLineDb; trusted_connection=true;");
            }

            public DbSet<AitCraft> airCrafts { get; set; }
            public DbSet<AirLine>  airLines { get; set; }
            //public DbSet<Nurse> nurses { get; set; }


            //public DbSet<Consultant> consultants { get; set; }

            //public DbSet<Patient_Con> patient_Cons { get; set; }


            //public DbSet<Drugs> drugs { get; set; }

            //public DbSet<Drug_Brand> drug_Brands { get; set; }

            //public DbSet<Nurse_Drug_Patient> nurse_Drug_Patients { get; set; }




            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //modelBuilder.Entity<Patient_Con>()
                //     .HasKey(x => new { x.ConsultantId, x.PatientId });


                //modelBuilder.Entity<Nurse_Drug_Patient>()
                //  .HasKey(x => new { x.PatientId, x.DateTime });



            }
        }


    }

