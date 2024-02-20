using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Configurations;
using Task.Models;


namespace Task
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<TaskEntity> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EF1_Task;Integrated Security=True;TrustServerCertificate=True");
        }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        /**** Check The Configuration Folder for the FluentAPI Code (Separation of Concerns) ****/
            new TaskEntityTypeConfiguration().Configure(modelBuilder.Entity<TaskEntity>());


            // Make Date column Required
            // modelBuilder.Entity<TaskEntity>().Property(e => e.Date).IsRequired();

            // Change table name to NewTask
            // modelBuilder.Entity<TaskEntity>().ToTable("NewTask");

            // Change the Date Column's name to Deadline
            // modelBuilder.Entity<TaskEntity>().Property(e => e.Date).HasColumnName("Deadline");
        }
    }
}
