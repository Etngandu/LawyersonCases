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
   public class LawyerConfiguration:IEntityTypeConfiguration<Lawyer>
    {
        public void Configure(EntityTypeBuilder<Lawyer> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(50);
            builder.Property(x => x.EmailAddres).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Hourly_rate).IsRequired().HasPrecision(18, 6);
            
        }
    }
}
