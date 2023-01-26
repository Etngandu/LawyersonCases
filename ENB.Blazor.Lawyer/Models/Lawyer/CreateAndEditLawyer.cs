using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
//using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using LawyerOffice.Entities;

namespace ENB.Blazor.Lawyer.Models
{
    public class CreateAndEditLawyer
    {

        #region "Public Properties"
        /// <summary>
        /// Gets or sets the Id of the Lawyer.
        /// </summary>

        public int Id
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the Name of the Gastenboek.
        /// </summary>
        [Required, DisplayName("First Name")]
        public string FirstName
        {
            get;
            set;
        }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "Last Name")]
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the PublicatieDatum of the Gastenboek.
        /// </summary>
        [DisplayName("Date of birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfBirth
        {
            get;
            set;
        } = DateTime.Now;



        public JobTitle Qualications { get; set; }


        public RefSpeciality Speciality { get; set; }

        [Required]
        public string EmailAddres { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Hourly_rate { get; set; }


        #endregion

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (Qualications == JobTitle.None)
        //    {
        //        yield return new ValidationResult("Qualications can't be None.", new[] { "Qualications" });
        //    }

        //    if (Speciality == RefSpeciality.None)
        //    {
        //        yield return new ValidationResult("Speciality can't be None.", new[] { "Speciality" });
        //    }
        //}
    }
}

        

        
    

