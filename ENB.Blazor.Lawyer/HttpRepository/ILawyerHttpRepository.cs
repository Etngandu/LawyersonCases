using ENB.Blazor.Lawyer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENB.Blazor.Lawyer.HttpRepository
{
  public  interface ILawyerHttpRepository
    {
        Task<List<DisplayLawyer>> GetLawyers();        
        Task<DisplayLawyer> GetLawyer(int Id); 
        Task<CreateAndEditLawyer> Retrievelawyer(int Id);
        Task<CreateAndEditLawyer> AddLawyer(CreateAndEditLawyer createAndEditLawyer);
        Task<CreateAndEditLawyer> EditLawyer(CreateAndEditLawyer createAndEditLawyer);
        Task DeleteLawyer(int Id);
    }
}
