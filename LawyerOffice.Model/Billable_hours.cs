using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawyerOffice.Infrastructure;

namespace LawyerOffice.Entities
{
  public class Billable_hours: DomainEntity<int>, IDateTracking
    {
        /// <summary>
        /// Gets or sets the Date case is opened.
        /// </summary>
        public DateTime Billabledate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Date case is closed.
        /// </summary>
        public DateTime timeFrom
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Date case is closed.
        /// </summary>
        public DateTime TimeTo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the date and time the object was created.
        /// </summary>

        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the date and time the object was last modified.
        /// </summary>
        public DateTime DateModified { get; set; }

        #region Methods

        /// <summary>
        /// Validates this object. It validates dependencies between properties and also calls Validate on child collections;
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //if (OpType == OperatorType.None)
            //{
            //    yield return new ValidationResult("Type can't be None.", new[] { "Type" });
            //}

            if (Billabledate < DateTime.Now.AddYears(Constants.MaxAgePerson * -1))
            {
                yield return new ValidationResult("Invalid range for DateOfBirth; must be between today and 130 years ago.", new[] { "DateOfBirth" });
            }            

            


        }
        #endregion

    }
}
