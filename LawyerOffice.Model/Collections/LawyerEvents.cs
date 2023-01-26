using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Entities.Collections
{

    /// <summary>
    /// Represents a collection of People instances in the system.
    /// </summary>
    public class LawyerEvents : CollectionBase<LawyerEvent>
    {       
    
        // <summary>
        /// Initializes a new instance of the <see cref="LawyerEvents"/> class.
        /// </summary>
        public LawyerEvents() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Operators"/> class.
        /// </summary>
        /// <param name="initialList">Accepts an IList of LawyerEvent as the initial list.</param>
        public LawyerEvents(IList<LawyerEvent> initialList) : base(initialList) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Operators"/> class.
        /// </summary>
        /// <param name="initialList">Accepts a CollectionBase of LawyerEvent as the initial list.</param>
        public LawyerEvents(CollectionBase<LawyerEvent> initialList) : base(initialList) { }

        /// <summary>
        /// Validates the current collection by validating each individual item in the collection.
        /// </summary>
        /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
        //public IEnumerable<ValidationResult> Validate()
        //{
        //    var errors = new List<ValidationResult>();
        //    foreach (var lawyerEvent in this)
        //    {
        //        errors.AddRange(lawyerEvent.Validate());
        //    }
        //    return errors;
        //}
    }
}

