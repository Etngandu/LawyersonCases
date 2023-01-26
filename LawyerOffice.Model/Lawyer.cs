using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using LawyerOffice.Entities.Collections;
using LawyerOffice.Infrastructure;

namespace LawyerOffice.Entities
{
  public  class Lawyer: DomainEntity<int>, IDateTracking
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Lawyer class.
        /// </summary>
        public Lawyer()
        {     
            LawyersOnCases = new LawyersOnCases();
            LawyerEvents = new LawyerEvents();
        }

        #endregion

        #region "Public Properties"

        /// <summary>
        /// Gets or sets the first name of this Lawyer.
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of this Lawyer.
        /// </summary>
        [Required]
        public string LastName { get; set; }


        /// <summary>
        /// Gets or sets the DateOfBirth of the Lawyer.
        /// </summary>
        /// 
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Hourly Rate of the Lawyer.
        /// </summary>
        /// 

        [Display(Name = "Hourly rate")]
        public decimal Hourly_rate
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the qualifications of this Lawyer.
        /// </summary>    
        /// 
        [Display(Name = "Job Title")]
        public JobTitle Qualications { get; set; }

        /// <summary>
        /// Gets or sets the speciality of this person.
        /// </summary>

        
        public RefSpeciality Speciality { get; set; }
        

        /// <summary>
        /// Gets the full name of this person.
        /// </summary>
        public string FullName
        {
            get
            {
                string temp = FirstName ?? string.Empty;
                if (!string.IsNullOrEmpty(LastName))
                {
                    if (temp.Length > 0)
                    {
                        temp += " ";
                    }
                    temp += LastName;
                }
                return temp;
            }
        }

        /// <summary>
        /// Gets or sets the e-mail addresses of this operator.
        /// </summary>
        /// 
        // [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Invalid Email Address")]
        [Required]
        public string EmailAddres { get;  set; }

        /// <summary>
        /// Gets or sets the phone numbers of this lawyer.
        /// </summary>
        public string PhoneNumber { get; set; }






        /// <summary>
        /// Gets or sets the LawyersOnCases of this Lawyer.
        /// </summary>
        public LawyersOnCases LawyersOnCases { get; set; }


        /// <summary>
        /// Gets or sets the LawyerEvents of this Lawyer.
        /// </summary>
        public LawyerEvents LawyerEvents { get; set; }

        /// <summary>
        /// Gets or sets the date and time the object was last modified.
        /// </summary>

        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the date and time the object was last modified.
        /// </summary>
        public DateTime DateModified { get; set; }

        /// <summary>
        /// Gets or sets the Relation to the Lawyer entity .
        /// </summary>
      //  public ICollection<Case> MCases { get; set; }
        #endregion

        #region Methods

        /// <summary>
        /// Validates this object. It validates dependencies between properties and also calls Validate on child collections;
        /// </summary>
        /// <param name="validationContext"></param>
        /// <returns>A IEnumerable of ValidationResult. The IEnumerable is empty when the object is in a valid state.</returns>
        public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Qualications == JobTitle.None)
            {
                yield return new ValidationResult("Qualification can't be None.", new[] { "Qualications" });
            }
            if (Speciality == RefSpeciality.None)
            {
                yield return new ValidationResult("Speciality can't be None.", new[] { "Speciality" });
            }

            if (DateOfBirth < DateTime.Now.AddYears(Constants.MaxAgePerson * -1))
            {
                yield return new ValidationResult("Invalid range for DateOfBirth; must be between today and 130 years ago.", new[] { "DateOfBirth" });
            }
            if (DateOfBirth > DateTime.Now)
            {
                yield return new ValidationResult("Invalid range for DateOfBirth; must be between today and 130 years ago.", new[] { "DateOfBirth" });
            }

            //if (String.IsNullOrEmpty(EmailAddres))
            //{
                
            //       var addr = new  MailAddress(EmailAddres);
            //    if (addr.Address==)
                        

            //}

            foreach (var result in LawyersOnCases.Validate())
            {
                yield return result;
            }

            


        }
        #endregion
    }
}
