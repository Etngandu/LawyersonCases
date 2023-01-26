using LawyerOffice.Infrastructure.DataContextStorage;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace LawyerOffice.Data.EF
{
    /// <summary>
    /// Manages instances of the LawyerContext and stores them in an appropriate storage container.
    /// </summary>
    public  class DataContextFactory:IDataContextStorageContainer<OfficeLawyerContext>
    {

       
       
        private readonly ILogger<DataContextFactory> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DataContextFactory(IHttpContextAccessor httpContextAccessor  , ILogger<DataContextFactory> logger)
        {
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }
        
                

        /// <summary>
        /// Clears out the current LawyerContext.
        /// </summary>
        public  void Clear()
        {
            var dataContextStorageFactory = new DataContextStorageFactory<OfficeLawyerContext>(_httpContextAccessor);
              var  dataContextStorageContainer= dataContextStorageFactory.CreateStorageContainer();
            dataContextStorageContainer.Clear();
        }

        /// <summary>
        /// Retrieves an instance of OfficeLawyerContext from the appropriate storage container or
        /// creates a new instance and stores that in a container.
        /// </summary>
        /// <returns>An instance of OfficeLawyerContext.</returns>
        public  OfficeLawyerContext GetDataContext()
        {
            var dataContextStorageFactory = new DataContextStorageFactory<OfficeLawyerContext>(_httpContextAccessor);
               var   dataContextStorageContainer= dataContextStorageFactory.CreateStorageContainer();
          
            var lawyerContext = dataContextStorageContainer.GetDataContext();
            if (lawyerContext == null)
            {
                var optionbldr = new DbContextOptionsBuilder<OfficeLawyerContext>();
                lawyerContext = new OfficeLawyerContext(optionbldr.Options);
                
                dataContextStorageContainer.Store(lawyerContext);
            }
            return lawyerContext;
        }

        

        public void Store(OfficeLawyerContext context)
        { }
    }
}
