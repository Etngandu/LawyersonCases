using ENB.Blazor.Lawyer.HttpRepository;
using ENB.Blazor.Lawyer.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENB.Blazor.Lawyer.Pages.Lawyer
{
    public partial class Lawyer
    {
        public IEnumerable<DisplayLawyer> LawyerList { get; set; } 

        [Inject]
        public ILawyerHttpRepository LawyerRepo { get; set; }
        protected async override Task OnInitializedAsync()
        {
            LawyerList = await LawyerRepo.GetLawyers();
            //just for testing
            foreach (var lawyer in LawyerList)
            {
                Console.WriteLine(lawyer.FullName);
            }
        }
    }
}
