using LawyerOffice.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Data.EF.ConfigurationEntity
{
    public class ApplicationUserConfiguration
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(150);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(150);          

        }
    }
}
