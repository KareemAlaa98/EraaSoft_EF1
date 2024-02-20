using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Models;

namespace Task.Configurations
{
    internal class TaskEntityTypeConfiguration : IEntityTypeConfiguration<TaskEntity>
    {
        public void Configure(EntityTypeBuilder<TaskEntity> builder)
        {
            // Make Date column Required
            builder.Property(e => e.Date).IsRequired();

            // Change table name to NewTask
            builder.ToTable("NewTask");

            // Change the Date Column's name to Deadline
            builder.Property(e => e.Date).HasColumnName("Deadline");
        }
    }
}
