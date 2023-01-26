using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LawyerOffice.Entities;
using LawyerOffice.Entities.Collections;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LawyerOfficeMvc.Models
{
    public class DisplayLawyerOnCase
    {

        public DisplayLawyerOnCase()

        {
            Casecollection = new Cases();
            Lawyercollection = new Lawyers();
        }
        #region "Public Properties"
        public int Id { get; set; }
        public int LawyerId { get; set; }

        [DisplayName("Title Case")]
        public int CaseId { get; set; }

        [DisplayName("Title Case")]
        public string Titlecase { get; set; }

        [DisplayName("Name Lawyer")]
        public string NameLawyer { get; set; }

        [DisplayName("Reference role")]
        public RefRoles Reference_role { get; set; }

        [DisplayName("Case status")]
        public CaseStatus Case_status { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Duration { get; set; }

        [DisplayName("Billing case")]
        [DisplayFormat(DataFormatString = "{0:n} €")]
        public decimal Billing_case { get; set; }

        [DisplayFormat(DataFormatString = "{0:C} €")]
        public decimal TotBilling { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Cases Casecollection { get; set; }
        public List<SelectListItem> ListCase { get; set; }
        public Lawyers Lawyercollection { get; set; }

        public List<DisplayLawyerOnCase> caseLawyers { get; set; }



        #endregion
    }
}