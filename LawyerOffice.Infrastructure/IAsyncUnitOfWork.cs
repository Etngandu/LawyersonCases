using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Infrastructure
{
    /// <summary>
    /// Represents a unit of work
    /// </summary>
    public interface IAsyncUnitOfWork : IDisposable
    {
        /// <summary>
        /// Commits the changes to the underlying data store. 
        /// </summary>
        /// <param name="resetAfterCommit">When true, all the previously retrieved objects should be cleared from the underlying model / cache.</param>
        Task Commit(bool resetAfterCommit);

        /// <summary>
        /// Undoes all changes to the entities in the model.
        /// </summary>
        void Undo();
    }
}

