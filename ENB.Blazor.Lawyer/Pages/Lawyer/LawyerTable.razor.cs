using ENB.Blazor.Lawyer.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENB.Blazor.Lawyer.Pages.Lawyer
{
    public partial class LawyerTable
    {
        [Parameter]
        public List<DisplayLawyer> Lawyers { get; set; }
    }
}
