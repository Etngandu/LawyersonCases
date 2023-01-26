using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawyerOffice.Entities;
using LawyerOffice.Infrastructure;
using LawyerOffice.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using LawyerOffice.Infrastructure.DataContextStorage;

namespace LawyerOffice.Data.EF.Repositories
{
    

    /// <summary>
    /// A concrete repository to work with lawyer in the system.
    /// </summary>
    public class CaseRepository : Repository<Case>, ICaseRepository
    {
         private readonly IDataContextStorageContainer<OfficeLawyerContext> _cdataContextFactory;
        public CaseRepository(IDataContextStorageContainer<OfficeLawyerContext> cdataContextFactory) : base(cdataContextFactory) 
        {
             _cdataContextFactory = cdataContextFactory;      
        }
        /// <summary>
        /// Gets a list of all Cases whose title exactly matches the search string.
        /// </summary>
        /// <param name="name">The last name that the system should search for.</param>
        /// <returns>An IEnumerable of Cases with the matching case.</returns>
        public IEnumerable<Case> FindByName(string titlecase)
        {
            return _cdataContextFactory.GetDataContext().Set<Case>().Where(x => x.CaseTitle == titlecase);
        }
    }
}
