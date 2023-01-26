using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LawyerOffice.Entities;
using LawyerOffice.Infrastructure;

namespace LawyerOffice.Data.EF.ConfigurationEntity
{
   public class CaseConfiguration:IEntityTypeConfiguration<Case>
    {
        public void Configure(EntityTypeBuilder<Case> builder)
        {
            builder.Property(x => x.CaseTitle).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Case_description).IsRequired().HasMaxLength(350);
            builder.Property(x => x.Other_case_details).IsRequired().HasMaxLength(500);
        }
    }
}
