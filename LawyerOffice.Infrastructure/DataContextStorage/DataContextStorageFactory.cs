using Microsoft.AspNetCore.Http;
using System.Web;

namespace LawyerOffice.Infrastructure.DataContextStorage
{
    /// <summary>
    /// A helper class to create application platform specific storage containers.
    /// </summary>
    /// <typeparam name="T">The type for which to create the container.</typeparam>
    public  class DataContextStorageFactory<T> where T : class
    {
        private  IDataContextStorageContainer<T> _dataContextStorageContainer { get; set; }

        private readonly IHttpContextAccessor _httpContextAccessor;

        public DataContextStorageFactory(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        /// <summary>
        /// Creates a new container that uses HttpContext.Current.Items (when HttpContext.Current is not null) or Thread.Items.
        /// </summary>
        /// <returns>A contact storage container to store objects. </returns>
        public IDataContextStorageContainer<T> CreateStorageContainer()
        {
            
            if (_dataContextStorageContainer == null)
            {
                if (_httpContextAccessor.HttpContext == null)
                {
                    _dataContextStorageContainer = new ThreadDataContextStorageContainer<T>();
                }
                else
                {
                    _dataContextStorageContainer = new HttpDataContextStorageContainer<T>(_httpContextAccessor);
                }
            }
            return _dataContextStorageContainer;
        }
    }
}
