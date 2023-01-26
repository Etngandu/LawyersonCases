using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;

namespace LawyerOffice.Data.EF
{
  public  class CDataContextFactory : IDbContextFactory<OfficeLawyerContext>
    {
        private readonly IServiceProvider _serviceProvider;
        //private readonly DbContextOptions<OfficeLawyerContext> _dbContextOptions;
       
        public CDataContextFactory(IServiceProvider serviceProvider) 
        {
             _serviceProvider = serviceProvider;
           // _dbContextOptions = dbContextOptions;          

        }

        public OfficeLawyerContext CreateDbContext()
        {

             string cstr = "Server=(localdb)\\MSSQLLocalDB;Database=LawyerEFCore;Trusted_Connection=True;MultipleActiveResultSets=true;";
        var optionbldr = new DbContextOptionsBuilder<OfficeLawyerContext>();
          //  optionbldr.UseSqlServer(cstr);
            // optionbldr.UseApplicationServiceProvider(_serviceProvider);
            //_dbContextOptions.Extensions.
            //var options = (DbContextOptions<OfficeLawyerContext>)_serviceProvider.
            return new OfficeLawyerContext(optionbldr.Options);
            //return ActivatorUtilities.CreateInstance<OfficeLawyerContext>(_serviceProvider);
        }

    }
}
