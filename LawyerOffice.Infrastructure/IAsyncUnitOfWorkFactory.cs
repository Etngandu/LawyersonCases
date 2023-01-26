using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Infrastructure
{
    /// <summary>
    /// Creates new instances of a unit of Work.
    /// </summary>
    public interface IAsyncUnitOfWorkFactory
    {
        /// <summary>
        /// Creates a new instance of a unit of work
        /// </summary>
        IAsyncUnitOfWork Create();

        /// <summary>
        /// Creates a new instance of a unit of work
        /// </summary>
        /// <param name="forceNew">When true, clears out any existing in-memory data storage / cache first.</param>
        IAsyncUnitOfWork Create(bool forceNew);
    }
}
