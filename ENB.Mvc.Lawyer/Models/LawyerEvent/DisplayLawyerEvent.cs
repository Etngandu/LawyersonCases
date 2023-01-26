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
    public class DisplayLawyerEvent
    {
        public int Id { get; set; }
        public int LawyerId { get; set; }       
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public string Color { get; set; }
        public Boolean AllDay { get; set; }
        public string NameLawyer { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
