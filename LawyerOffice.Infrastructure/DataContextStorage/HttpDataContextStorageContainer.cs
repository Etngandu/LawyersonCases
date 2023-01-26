
using System.Linq;
using System.Net.Http;
using System.Web;
using Microsoft.AspNetCore.Http;


namespace LawyerOffice.Infrastructure.DataContextStorage
{
    /// <summary>
    /// A Helper class to store objects like a DataContext in the HttpContext.Current.Items collection.
    /// </summary>
    /// <typeparam name="T">The type of object to store.</typeparam>
    public class HttpDataContextStorageContainer<T> : IDataContextStorageContainer<T> where T : class
    {
        private const string DataContextKey = "DataContext";
        private readonly IHttpContextAccessor _httpContextAccessor;



        /// <summary>
        /// Returns an object from the container when it exists. Returns null otherwise.
        /// </summary>
        /// <returns>The object from the container when it exists, null otherwise.</returns>

        public HttpDataContextStorageContainer(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;           

        }

        
        public T GetDataContext()
        {
            var Current = _httpContextAccessor.HttpContext;
            T objectContext = null;
           
            
            //  _httpContextAccessor.HttpContext.
            if (Current.Items.ContainsKey(DataContextKey))
            {
                objectContext = (T)Current.Items[DataContextKey];
            }
            return objectContext;
        }

        /// <summary>
        /// Clears the object from the container.
        /// </summary>
        public void Clear()
        {
            var Current = _httpContextAccessor.HttpContext;
            if (Current.Items.ContainsKey(DataContextKey))
            {
                Current.Items[DataContextKey] = null;
            }
        }

        /// <summary>
        /// Stores the object in HttpContext.Current.Items.
        /// </summary>
        /// <param name="objectContext">The object to store.</param>
        public void Store(T objectContext)
        {
            var Current = _httpContextAccessor.HttpContext;
            if (Current.Items.ContainsKey(DataContextKey))
            {
                 Current.Items[DataContextKey] = objectContext;
            }
            else
            {
                Current.Items.Add(DataContextKey, objectContext);
            }
        }
    }
}
