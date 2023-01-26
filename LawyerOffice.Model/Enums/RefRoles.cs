using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerOffice.Entities
{
    /// <summary>
    /// Determines the type of a RefRoles record.
    /// </summary>
    public enum RefRoles
    {
        /// <summary>
        /// Indicates an unidentified value.
        /// </summary>
        None = 0,
        /// <summary>
        /// Indicates Duties of Lawyers.
        /// </summary>
        /// 
        [Display(Name = "Advise and represent clients in courts")]
        Advise_and_represent_clients_in_courts = 1,

        /// <summary>
        /// Indicates Duties of Lawyers.
        /// </summary>
        ///
        [Display(Name = "Communicate with clients,colleagues,judges")]
        Communicate_clients_colleagues_judges = 2,
        /// <summary>
        /// Indicates Duties of Lawyers.
        /// </summary>
        /// 
        [Display(Name = "Conduct research and analysis of legal problems")]
        Conduct_research_and_analysis_of_legal_problems = 3,

        /// <summary>
        /// Indicates Duties of Lawyers.
        /// </summary>
        /// 
        [Display(Name = "Interpret laws, rulings, and regulations")]
        Interpret_laws_rulings_and_regulations = 4,
    }
}
