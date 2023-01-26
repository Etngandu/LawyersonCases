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
  public  class Case : DomainEntity<int>, IDateTracking
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Case class.
        /// </summary>
        public Case()
        {
            
            LawyersOnCases = new LawyersOnCases();

        }

        #endregion

        #region "Public Properties"

        /// <summary>
        /// Gets or sets the first name of this Lawyer.
        /// </summary>
        [Required]
        [Display(Name = "Case Title")]
        public string CaseTitle { get; set; }



        /// <summary>
        /// Gets or sets the Date case is opened.
        /// </summary>
        /// 
        [Display(Name = "Case Opened date")]
        public DateTime ? Case_Opened_date
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Date case is closed.
        /// </summary>
        /// 
        [Display(Name = "Case Closed date")]
        public DateTime ? Case_Closed_date
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Hourly Rate of the Lawyer.
        /// </summary>
        /// 
        [Display(Name = "Case Opened date")]
        public string Case_description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the qualifications of this Lawyer.
        /// </summary>  
        /// 
        [Display(Name = "Other case details")]
        public string Other_case_details { get; set; }

        /// <summary>
        /// Gets or sets the status of this case.
        /// </summary>
        /// 

        [Display(Name = "Case  Status")]
        public CaseStatus Statuscase { get; set; }



        public LawyersOnCases LawyersOnCases { get; set; }
        /// <summary>
        /// Gets or sets the date and time the object was created.
        /// </summary>

        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the date and time the object was last modified.
        /// </summary>
        public DateTime DateModified { get; set; }


        /// <summary>
        /// Gets or sets the Relation to the Lawyer entity .
        /// </summary>
       // public ICollection<Lawyer> MLawyers { get; set; }
        #endregion

        #region Methods

        /// <summary>
        /// Validates this object. It validates dependencies between properties and also calls Validate on child collections;
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Statuscase == CaseStatus.None)
            {
                yield return new ValidationResult("Statuscase can't be None.", new[] { "Type" });
            }

            if (Case_Opened_date < DateTime.Now.AddYears(Constants.MaxAgePerson * -1))
            {
                yield return new ValidationResult("Invalid range for DateOfBirth; must be between today and 130 years ago.", new[] { "DateOfBirth" });
            }
            if (Case_Closed_date > DateTime.Now)
            {
                yield return new ValidationResult("Invalid range for DateOfBirth; must be between today and 130 years ago.", new[] { "DateOfBirth" });
            }

            foreach (var result in LawyersOnCases.Validate())
            {
                yield return result;
            }

        }
        #endregion
    }
}
