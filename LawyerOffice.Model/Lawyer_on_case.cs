using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawyerOffice.Infrastructure;

namespace LawyerOffice.Entities
{
  public  class Lawyer_on_case:DomainEntity<int>, IDateTracking
    {
        #region Properties


        /// <summary>
        /// Gets or sets the owner Lawyer.
        /// </summary>
        [Owner()]
        public Lawyer Owner_lawyer { get; set; }

        /// <summary>
        /// Gets or sets the owner LawyerID.
        /// </summary>
        public int Owner_LawyerId { get; set; }

        /// <summary>
        /// Gets or sets the owner Case.
        /// </summary>
        [Owner()]
        public Case Owner_Case { get; set; }

        /// <summary>
        /// Gets or sets the owner Case ID.         
        /// </summary>
        public int Owner_CaseId { get; set; }

        /// <summary>
        /// Gets or sets the Reference Role.
        /// </summary>
        public RefRoles Reference_role { get; set; }

        /// <summary>
        /// Gets or sets the status of this case.
        /// </summary>
        /// 

        [Display(Name = "Case  Status")]
        public CaseStatus Case_status { get; set; }

        /// <summary>
        /// Gets or sets the start time of the billing.
        /// </summary>
        /// 
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets the End time of the billing.
        /// </summary>
        /// 
        public string EndTime { get; set; }

        /// <summary>
        /// Gets or sets the duration of the billing.
        /// </summary>
        /// 
        public string Duration {get; set;}

        /// <summary>
        /// Gets or sets the Billing.
        /// </summary>
        /// 

        public decimal Billing_case { get; set; }

        /// <summary>
        /// Gets or sets the date and time the object was created.
        /// </summary>
        /// 
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
            if (Case_status == CaseStatus.None)
            {
                yield return new ValidationResult("StatusLinkcase can't be None.", new[] { "Type" });
            }

            if (Reference_role == RefRoles.None)
            {
                yield return new ValidationResult("Reference_role can't be None.", new[] { "Type" });
            }
            


        }
        #endregion


    }
}
