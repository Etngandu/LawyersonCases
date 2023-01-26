using LawyerOffice.Infrastructure;
using LawyerOffice.Infrastructure.DataContextStorage;
using Microsoft.EntityFrameworkCore;

namespace LawyerOffice.Data.EF
{
  public  class AsyncEFUnitOfWorkFactory :IAsyncUnitOfWorkFactory
    {
        private readonly IDataContextStorageContainer<OfficeLawyerContext> _cdataContextFactory;

        public AsyncEFUnitOfWorkFactory(IDataContextStorageContainer<OfficeLawyerContext> cdataContextFactory)
        {
            _cdataContextFactory = cdataContextFactory;

        }
        /// <summary>
        /// Creates a new instance of an EFUnitOfWork.
        /// </summary>
        public IAsyncUnitOfWork Create()
        {
            return Create(false);
        }

        /// <summary>
        /// Creates a new instance of an EFUnitOfWork.
        /// </summary>
        /// <param name="forceNew">When true, clears out any existing data context from the storage container.</param>
        public IAsyncUnitOfWork Create(bool forceNew)
        {
            return new AsyncEFUnitOfWork(forceNew, _cdataContextFactory);
        }

    }
}
