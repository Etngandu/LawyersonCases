using System.Collections.Generic;
using LawyerOffice.Infrastructure;

namespace LawyerOffice.Entities.Repositories
{
  /// <summary>
  /// Defines the various methods available to work with people in the system.
  /// </summary>
  public interface ILawyerRepository : IRepository<Lawyer, int>
  {
    /// <summary>
    /// Gets a list of all the people whose last name exactly matches the search string.
    /// </summary>
    /// <param name="name">The last name that the system should search for.</param>
    /// <returns>An IEnumerable of Person with the matching people.</returns>
        IEnumerable<Lawyer> FindByName(string name);
  }
}
