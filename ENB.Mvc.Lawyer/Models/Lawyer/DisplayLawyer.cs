using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using Microsoft.AspNetCore.Http;
using LawyerOffice.Entities;

namespace ENB.Mvc.Lawyer.Models
{
  public class DisplayLawyer
    {
    public int Id { get; set; }
   [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
   public DateTime DateCreated { get; set; }

   [DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
   public DateTime DateModified { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }

   [DisplayFormat(DataFormatString = "{0:n} €")]
   public decimal Hourly_rate { get; set; }

   //[DisplayFormat(DataFormatString = "{0: MM/dd/yyyy}")]
   [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
    public DateTime DateOfBirth { get; set; }
    public JobTitle Qualications { get; set; }
    public RefSpeciality Speciality { get; set; }
    public string EmailAddres { get; set; }
    public string PhoneNumber { get; set; }

    public DisplayCase MyCaseDisplay { get; set; }
        

    }
}