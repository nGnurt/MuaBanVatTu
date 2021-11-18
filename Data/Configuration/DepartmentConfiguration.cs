using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(x=>x.DepartmentId);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Leader).IsRequired();
            builder.HasOne(x => x.Order).WithMany(x => x.Department).HasForeignKey(x => x.DepartmentId);
        }
    }
}
