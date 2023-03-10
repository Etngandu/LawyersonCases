using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LawyerOffice.Entities;
using LawyerOffice.Entities.Collections;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ENB.Mvc.Lawyer.Models
{
    public class CreateAndEditLawyerEvent : IValidatableObject
    {
        public int Id { get; set; }

        [DisplayName("Name Lawyer")]
        public int LawyerId { get; set; }

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public string Color { get; set; }
        public Boolean AllDay { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public List<SelectListItem> ListLawyers { get; set; }
        public string NameLawyer { get; set; }
        public string EventStatus { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Color))
            {
                yield return new ValidationResult("LawyerEventStatus can't be None.", new[] { "Color" });
            }
        }
    }
}
