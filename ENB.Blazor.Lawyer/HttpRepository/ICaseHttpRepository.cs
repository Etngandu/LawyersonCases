using ENB.Blazor.Lawyer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENB.Blazor.Lawyer.HttpRepository
{
  public  interface ICaseHttpRepository
    {
        Task<List<DisplayCase>> GetCases();
        Task<DisplayCase> GetCase(int Id);       
        Task<CreateAndEditCase> RetrieveCase(int Id);
        Task<CreateAndEditCase> AddCase(CreateAndEditCase createAndEditCase);
        Task<CreateAndEditCase> EditCase(CreateAndEditCase createAndEditCase);
        Task DeleteCase(int Id);
    }
}
