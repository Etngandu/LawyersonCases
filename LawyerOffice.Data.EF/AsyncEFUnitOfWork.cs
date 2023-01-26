using LawyerOffice.Infrastructure;
using LawyerOffice.Infrastructure.DataContextStorage;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace LawyerOffice.Data.EF
{
    /// <summary>
    /// Defines a Unit of Work using an EF DbContext under the hood.
    /// </summary>
    public class AsyncEFUnitOfWork : IAsyncUnitOfWork
    {
        private readonly IDataContextStorageContainer<OfficeLawyerContext> _cdataContextFactory;

        /// <summary>
        /// Initializes a new instance of the EFUnitOfWork class.
        /// </summary>
        /// <param name="forceNewContext">When true, clears out any existing data context first.</param>

        

        public AsyncEFUnitOfWork(bool forceNewContext, IDataContextStorageContainer<OfficeLawyerContext> cdataContextFactory
                                )
        {
            if (forceNewContext)
            {
                _cdataContextFactory.Clear();
            }
            _cdataContextFactory = cdataContextFactory;
        }

        /// <summary>
        /// Saves the changes to the underlying DbContext.
        /// </summary>
        public  async void Dispose()
        {
            //CancellationTokenSource source = new CancellationTokenSource();
            //CancellationToken token = source.Token;
            await  _cdataContextFactory.GetDataContext().SaveChangesAsync();
        }

        /// <summary>
        /// Saves the changes to the underlying DbContext.
        /// </summary>
        /// <param name="resetAfterCommit">When true, clears out the data context afterwards.</param>
        public async Task Commit(bool resetAfterCommit)
        {
           await _cdataContextFactory.GetDataContext().SaveChangesAsync();
            if (resetAfterCommit)
            {
                _cdataContextFactory.Clear();
            }
        }

        /// <summary>
        /// Undoes changes to the current DbContext by removing it from the storage container.
        /// </summary>
        public void Undo()
        {
            _cdataContextFactory.Clear();
        }
    }
}
