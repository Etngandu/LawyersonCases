using LawyerOffice.Infrastructure.DataContextStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawyerOffice.Entities;
using LawyerOffice.Infrastructure;
using LawyerOffice.Entities.Repositories;
using Microsoft.EntityFrameworkCore;

namespace LawyerOffice.Data.EF.Repositories
{
    /// <summary>
    /// A concrete repository to work with case in the system.
    /// </summary>
    public class AsyncLawyerRepository:AsyncRepository<Lawyer>,IAsyncLawyerRepository
    {
        private readonly IDataContextStorageContainer<OfficeLawyerContext> _cdataContextFactory;
        public AsyncLawyerRepository(IDataContextStorageContainer<OfficeLawyerContext> cdataContextFactory) : base(cdataContextFactory)
        {
            _cdataContextFactory = cdataContextFactory;
        }
        /// <summary>
        /// Gets a list of all lawyers whose last name exactly matches the search string.
        /// </summary>
        /// <param name="name">The last name that the system should search for.</param>
        /// <returns>An IEnumerable of Person with the matching people.</returns>
        /// 
        public IEnumerable<Lawyer> FindByName(string lastname)
        {
            return _cdataContextFactory.GetDataContext().Set<Lawyer>().Where(x => x.LastName == lastname);
        }
    }
}
