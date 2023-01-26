using LawyerOffice.Infrastructure;
using LawyerOffice.Infrastructure.DataContextStorage;
using Microsoft.EntityFrameworkCore;

namespace LawyerOffice.Data.EF
{
    /// <summary>
    /// Defines a Unit of Work using an EF DbContext under the hood.
    /// </summary>
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly IDataContextStorageContainer<OfficeLawyerContext> _cdataContextFactory;
       // private readonly DbContextOptions<OfficeLawyerContext> _dbContextOptions;
        /// <summary>
        /// Initializes a new instance of the EFUnitOfWork class.
        /// </summary>
        /// <param name="forceNewContext">When true, clears out any existing data context first.</param>
        public EFUnitOfWork(bool forceNewContext, IDataContextStorageContainer<OfficeLawyerContext> cdataContextFactory
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
        public void Dispose()
        {
           _cdataContextFactory.GetDataContext().SaveChanges();
        }

        /// <summary>
        /// Saves the changes to the underlying DbContext.
        /// </summary>
        /// <param name="resetAfterCommit">When true, clears out the data context afterwards.</param>
        public void Commit(bool resetAfterCommit)
        {
            _cdataContextFactory.GetDataContext().SaveChanges();
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
