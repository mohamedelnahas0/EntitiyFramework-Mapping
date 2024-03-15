using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesMap.Entites;

namespace SalesMap.Context
{
    public class SlaesOfficedbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =ELNAHAS\\SQLEXPRESS; database=SalesOffice; trusted_connection=true;");
        }

        public DbSet<Sales_Office> sales_Offices { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Property>  properties { get; set; }

        public DbSet<Owner>  owners { get; set; }


        public DbSet<Prop_Owner>  prop_Owners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prop_Owner>()
                 .HasKey(x => new { x.propertyId, x.ownerId });


        }
    }

   
}
