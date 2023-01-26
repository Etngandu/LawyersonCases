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
   public class LawyerEventConfiguration : IEntityTypeConfiguration<LawyerEvent>
    {
        public void Configure(EntityTypeBuilder<LawyerEvent> builder)
        {
            builder.Property(x => x.Title).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(300);
            builder.Property(x => x.Color).IsRequired().HasMaxLength(100);
        }
    }
}
