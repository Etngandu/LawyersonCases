using System.Web;
using System.ComponentModel.DataAnnotations;
using LawyerOffice.Entities;
using LawyerOffice.Entities.Collections;
using System.ComponentModel;
using System.Collections.Generic;

namespace LawyerOfficeMvc.Models
{
    public class CreateAndEditLawyerOnCase : IValidatableObject
    {

        public CreateAndEditLawyerOnCase()
        
        { 
            Casecollection = new Cases();
            Lawyercollection = new Lawyers();
        }

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
        public Cases Casecollection { get; set; }
        public string NameLawyer { get; set; }
        public Lawyers Lawyercollection { get; set; }        
        public string StartTime { get; set; }         
        public string EndTime { get; set; }


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

            foreach (var result in Casecollection.Validate())
            {
                yield return result;
            }

            foreach (var result in Lawyercollection.Validate())
            {
                yield return result;
            }

        }
    }
}