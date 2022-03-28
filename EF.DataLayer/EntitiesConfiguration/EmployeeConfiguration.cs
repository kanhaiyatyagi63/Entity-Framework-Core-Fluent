using EF.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.DataLayer.EntitiesConfiguration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.ToTable("Employees");

            builder.HasKey(x => x.EmpId);

            builder.Property(x => x.Name).HasMaxLength(100)
                                         .IsRequired();

            builder.Property(x => x.Email).HasMaxLength(100);

            builder.HasIndex(x => x.Email).IsUnique();

            builder.Property(x => x.DateOfBirth)
                   .IsRequired()
                   .HasColumnName("DOB");


            builder.HasOne(x=>x.Department)
                   .WithMany(x=>x.Employees)
                   .HasForeignKey(x=>x.DepartmentId);
        }
    }
}
