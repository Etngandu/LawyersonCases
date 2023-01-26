using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LawyerOffice.Entities.Collections
{
    /// <summary>
    /// Represents a collection of People instances in the system.
    /// </summary>
  public  class LawyersOnCases: CollectionBase<Lawyer_on_case>
    {
        // <summary>
        /// Initializes a new instance of the <see cref="Operators"/> class.
        /// </summary>
        public LawyersOnCases() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Operators"/> class.
        /// </summary>
        /// <param name="initialList">Accepts an IList of Person as the initial list.</param>
        public LawyersOnCases(IList<Lawyer_on_case> initialList) : base(initialList) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Operators"/> class.
        /// </summary>
        /// <param name="initialList">Accepts a CollectionBase of Person as the initial list.</param>
        public LawyersOnCases(CollectionBase<Lawyer_on_case> initialList) : base(initialList) { }

        /// <summary>
        /// Validates the current collection by validating each individual item in the collection.
        /// </summary>
        /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
        public IEnumerable<ValidationResult> Validate()
        {
            var errors = new List<ValidationResult>();
            foreach (var lawyer in this)
            {
                errors.AddRange(lawyer.Validate());
            }
            return errors;
        }
    }
}
