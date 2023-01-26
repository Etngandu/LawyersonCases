using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawyerOffice.Infrastructure;
using LawyerOffice.Entities.Collections;

namespace LawyerOffice.Entities
{
    public class LawyerEvent : DomainEntity<int>,IDateTracking
    {
        #region  "Public Properties"
        public int LawyerId { get; set; }
        public Lawyer Lawyer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public  string Color { get; set; }
        public Boolean AllDay { get; set; }
        /// <summary>
        /// Gets or sets the date and time the object was last created.
        /// </summary>

        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Gets or sets the date and time the object was last modified.
        /// </summary>

        public DateTime DateModified { get; set; }
        #endregion


        #region Methods
        /// <summary>
        /// Validates this object. It validates dependencies between properties and also calls Validate on child collections;
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Color))
            {
                yield return new ValidationResult("LawyerEventStatus can't be None.", new[] { "LawyerEventStatus" });
            }
        }
        #endregion
    }
}
