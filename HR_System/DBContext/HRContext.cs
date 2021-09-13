using HR_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HR_System.DBContext
{

    public class HRContext: DbContext
    {
        public HRContext()
        {
        }

        public HRContext(DbContextOptions<HRContext> options)
        : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Composit Primary Key in Job History Table
            modelBuilder.Entity<Job_History>()
                .HasKey(j => new { j.EmployeeId, j.StartDate });

            // One to many relationship between Employee & Manager
            modelBuilder.Entity<Employee>()
            .HasOne(x => x.Manager)
            .WithMany(x => x.Employees)
            .HasForeignKey(x => x.ManagerId);


        /*    // one to many relationship between Employee & Department
            modelBuilder.Entity<Employee>()
            .HasOne(x => x.Department)
            .WithMany(x => x.Employees)
            .HasForeignKey(x => x.DepartmentId);

            //one to one between Manager & Department 
            modelBuilder.Entity<Department>()
            .HasOne(x => x.Employee)
            .WithOne(x => x.Department);
        */

            base.OnModelCreating(modelBuilder);

        }
        DbSet<Region> Regions { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Job> Jobs { get; set; }
        DbSet<Job_History> JobHistory { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Country> Countries { get; set; }
    }
}
