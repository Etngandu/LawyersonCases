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
   public class LawyerOnCaseConfiguration:IEntityTypeConfiguration<Lawyer_on_case>
    {
        public void Configure(EntityTypeBuilder<Lawyer_on_case> builder)
        {
            builder.Property(x => x.StartTime).IsRequired().HasMaxLength(15);
            builder.Property(x => x.EndTime).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Duration).IsRequired().HasMaxLength(15);
            builder.Property(x => x.Billing_case).IsRequired().HasPrecision(18, 6);
        }
    }
}
