using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LawyerOffice.Entities;

namespace LawyerOfficeMvc.Models
{
    public class CreateAndEditCase: IValidatableObject
    {
        #region "Public Properties"

        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the first name of this Lawyer.
        /// </summary>
        [Required]
        public string CaseTitle { get; set; }



        /// <summary>
        /// Gets or sets the Date case is opened.
        /// </summary>
         [Required]
        public DateTime Case_Opened_date
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Date case is closed.
        /// </summary>
        [Required]
        public DateTime Case_Closed_date
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Hourly Rate of the Lawyer.
        /// </summary>
        [Required]
        public string Case_description
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the qualifications of this Lawyer.
        /// </summary>    
        public string Other_case_details { get; set; }

        /// <summary>
        /// Gets or sets the status of this case.
        /// </summary>

        public CaseStatus Statuscase { get; set; }


        /// <summary>
        /// Gets or sets the date and time the object was created.
        /// </summary>

        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the date and time the object was last modified.
        /// </summary>
        public DateTime DateModified { get; set; }

        #endregion

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Statuscase == CaseStatus.None)
            {
                yield return new ValidationResult("Statuscase can't be None.", new[] { "Type" });
            }
            
        }



    }
}