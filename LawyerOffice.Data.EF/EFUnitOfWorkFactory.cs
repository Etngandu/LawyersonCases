using LawyerOffice.Infrastructure;
using LawyerOffice.Infrastructure.DataContextStorage;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LawyerOffice.Data.EF
{

    /// <summary>
    /// Creates new instances of an EF unit of Work.
    /// </summary>
    public class EFUnitOfWorkFactory : IUnitOfWorkFactory
    {

        private readonly IDataContextStorageContainer<OfficeLawyerContext> _cdataContextFactory;
        
        public EFUnitOfWorkFactory(IDataContextStorageContainer<OfficeLawyerContext> cdataContextFactory  )
        {
            _cdataContextFactory = cdataContextFactory;
          
        }
        /// <summary>
        /// Creates a new instance of an EFUnitOfWork.
        /// </summary>
        public IUnitOfWork Create()
        {
          return  Create(false);
        }

        /// <summary>
        /// Creates a new instance of an EFUnitOfWork.
        /// </summary>
        /// <param name="forceNew">When true, clears out any existing data context from the storage container.</param>
        public IUnitOfWork Create(bool forceNew)
        {
            return new EFUnitOfWork(forceNew,_cdataContextFactory);
        }


    }
}
