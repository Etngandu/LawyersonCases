using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LawyerOffice.Entities;
using System.ComponentModel;

namespace ENB.Mvc.Lawyer.Models
{
    public class DisplayCase
    {

        public int Id { get; set; }
        public string CaseTitle { get; set; }

        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
        [DisplayName("Case Opened date")]
        public DateTime Case_Opened_date { get; set; }

        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
        [DisplayName("Case Closed date")]
        public DateTime Case_Closed_date { get; set; }

        [DisplayName("Case description")]
        public string Case_description { get; set; }

        [DisplayName("Other case details")]
        public string Other_case_details { get; set; }
        public CaseStatus Statuscase { get; set; }

        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
        public DateTime DateCreated { get; set; }

        [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
        public DateTime DateModified { get; set; }



    }
}