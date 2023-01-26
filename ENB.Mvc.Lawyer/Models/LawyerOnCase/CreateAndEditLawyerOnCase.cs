using System.Web;
using System.ComponentModel.DataAnnotations;
using LawyerOffice.Entities;
using LawyerOffice.Entities.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace ENB.Mvc.Lawyer.Models
{
    public class CreateAndEditLawyerOnCase : IValidatableObject
    {

        

        #region "Public Properties"
        public int Id { get; set; }

        [DisplayName("Name Lawyer")]
        public int? LawyerId { get; set; }
        [DisplayName("Title Case")]
        public int? CaseId { get; set; }

        [DisplayName("Reference role")]
        public  RefRoles Reference_role { get; set; }

        [DisplayName("Case status")]
        public CaseStatus Case_status { get; set; }
        public string NameCase { get; set; }
       

        public List<SelectListItem> ListCases { get; set; }
        public string NameLawyer { get; set; }
       
        public List<SelectListItem> ListLawyers { get; set; }
        public string StartTime { get; set; }         
        public string EndTime { get; set; }

        public string Duration
        {

            set { }

            get
            {
                TimeSpan Tduration = TimeSpan.Zero;
                if (StartTime != null & EndTime != null)
                {
                    Tduration = DateTime.Parse(EndTime).Subtract(DateTime.Parse(StartTime));
                }
                return Tduration.ToString();
            }

        }

        public decimal Billing_case { get; set; }
        #endregion

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Reference_role == RefRoles.None)
            {
                yield return new ValidationResult("Reference Role can't be None.", new[] { "Reference_role" });
            }

            if (Case_status == CaseStatus.None)
            {
                yield return new ValidationResult("Case Status can't be None.", new[] { "Case_status" });
            }

            if (LawyerId == 0)
            {
                yield return new ValidationResult("Lawyer Id can't be None.", new[] { "LawyerId" });
            }

            

        }
    }
}