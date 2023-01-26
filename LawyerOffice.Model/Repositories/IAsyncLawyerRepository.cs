using LawyerOffice.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Entities.Repositories
{
    /// <summary>
    /// Defines the various methods available to work with people in the system.
    /// </summary>
  public interface IAsyncLawyerRepository : IAsyncRepository<Lawyer,int>
    {
        /// <summary>
        /// Gets a list of all the people whose last name exactly matches the search string.
        /// </summary>
        /// <param name="name">The last name that the system should search for.</param>
        /// <returns>An IEnumerable of Person with the matching people.</returns>
       
        IEnumerable<Lawyer> FindByName(string name);
    }
}
