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
    public class EmployeeLanguageConfiguration : IEntityTypeConfiguration<EmployeeLanguage>
    {
        public void Configure(EntityTypeBuilder<EmployeeLanguage> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Employee)
                   .WithMany(x => x.EmployeeLanguages)
                   .HasForeignKey(x => x.EmployeeId);

            builder.HasOne(x => x.Language)
                   .WithMany(x => x.EmployeeLanguages)
                   .HasForeignKey(x => x.LanguageId);

        }
    }
}
